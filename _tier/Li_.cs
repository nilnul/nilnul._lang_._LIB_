using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.lang._tier
{
	/// <summary>
	/// the tier within hierarchy of a lang can takes the echelon of units in military as a reference;
	/// </summary>
	/// vs:
	///		marine
	///		airforce
	///		navy
	///			,the army's echelon is simpler;
	internal enum Li_
	{
		/*
		 * defense.gov/Multimedia/Experience/Military-Units/Army/
		 * Four soldiers make up a team — a noncommissioned officer and three junior enlisted soldiers. Teams with special functions may also include officers or warrant officers. An infantry fire team might include two riflemen, one of whom is the team leader; a grenadier and an automatic rifleman, who is used when small reconnaissance or special missions are required. Teams can serve as a base-of-fire or as a maneuver element.
		 */
		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		crew
		Team
			,
		/// <summary>
		/// Two teams make up a squad, which has four to 10 soldiers. In an infantry squad, the teams divide duties: one serves as a base-of-fire element, while the other serves as the maneuver element. A staff sergeant is often in charge.
		/// </summary>
		/// alias:
		///		section
		///		patrol
		Squad
			,
		/// <summary>
		/// commanded by: lieutenant
		/// </summary>
		/// alias:
		///		排
		///	vs:
		///		staffel
		Platoon
			,
		Company
			,
		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		营
		Battalion
			,
		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		团
		Regiment
			,
		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		旅
		Brigade
			,
		/// <summary>
		/// this can be corresponed to the xml div tag, which comprises several paragraphs;
		/// </summary>
		/// alias:
		///		师
		///		divizion
		///		dywizjon
		///		divizijun
		Division
			,
		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		军
		///		mustering
		///		legion
		Corps
			,
		Army
			,
		/// <summary>
		/// 
		/// </summary>
		/// vs:
		///		wing
		Group
			,
		/// <summary>
		/// 
		/// </summary>
		/// alias:
		///		军区
		///		战区
		///		comand
		///		theater
		///		region
		///		legion
		///		district
		Region

	}
}
