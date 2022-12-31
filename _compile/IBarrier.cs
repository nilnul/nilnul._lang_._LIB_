using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._compile
{
	/*cnblogs.com/chenny7/p/13589241.html
	 * 编译器会做非常多的优化，指令重排序是其中一种
	 * CPU的乱序执行并不是任意的乱序，比如：

a++; b=a+1; c--;
由于b=a+1依赖于前一条指令a++的执行结果，所以b=a+1将在“执行”阶段之前被阻塞，直到a++的执行结果被生成出来；而c--跟前面没有依赖，它可能在b=a+1之前就能执行完。

像这样有依赖关系的指令如果挨得很近，后一条指令必定会因为等待前一条执行的结果，而在流水线中阻塞很久，占用流水线的资源。

而编译器的乱序，作为编译优化的一种手段，则试图通过指令重排将这样的两条指令拉开距离, 以至于后一条指令进入CPU的时候，前一条指令结果已经得到了，那么也就不再需要阻塞等待了。比如将指令重排为：

a++; c--; b=a+1;


	为什么可以这么做呢？对于单线程来说，a 和 b 与 c 的写入顺序，compiler认为没有任何问题。
	 * 如果操作的不是局部变量，在多线程下可能会出现问题。
	 * barrier()就是compiler提供的屏障，作用是告诉compiler内存中的值已经改变，之前对内存的缓存（缓存到寄存器）都需要抛弃，barrier()之后的内存操作需要重新从内存load，而不能使用之前寄存器缓存的值。并且可以防止compiler优化barrier()前后的内存访问顺序。barrier()就像是代码中的一道不可逾越的屏障，barrier前的 load/store 操作不能跑到barrier后面；同样，barrier后面的 load/store 操作不能在barrier之前。
	 * 注意，inline函数不具有compiler barriers的作用，当我们需要考虑compiler barriers时，一定要显示的插入barrier()，而不是依靠函数调用附加的隐式compiler barriers。因为，谁也无法保证调用的函数不会被compiler优化成inline方式。
	 * 有时，通过volatile也可以解决

	 */
	class IBarrier
	{
	}
}
