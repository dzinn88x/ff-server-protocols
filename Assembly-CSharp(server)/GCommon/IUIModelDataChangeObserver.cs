using System;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02001013 RID: 4115
	[Token(Token = "0x2001013")]
	public interface IUIModelDataChangeObserver
	{
		// Token: 0x06003DE4 RID: 15844
		[Token(Token = "0x6003DE4")]
		void OnDataChanged(UIBaseModel model, uint propID, params object[] param);

		// Token: 0x06003DE5 RID: 15845
		[Token(Token = "0x6003DE5")]
		uint GetInterestedPropID(UIBaseModel model);
	}
}
