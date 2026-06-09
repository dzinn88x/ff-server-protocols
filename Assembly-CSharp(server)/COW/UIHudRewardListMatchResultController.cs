using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001953 RID: 6483
	[Token(Token = "0x2001953")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6024", Offset = "0x10F6024")]
	public class UIHudRewardListMatchResultController : UIPopupWindowController
	{
		// Token: 0x060083A4 RID: 33700 RVA: 0x00023C10 File Offset: 0x00021E10
		[Token(Token = "0x60083A4")]
		[Address(RVA = "0x17FBCA8", Offset = "0x17FBCA8", VA = "0x7BBBFFBCA8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083A5 RID: 33701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083A5")]
		[Address(RVA = "0x17FBCF8", Offset = "0x17FBCF8", VA = "0x7BBBFFBCF8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083A6 RID: 33702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083A6")]
		[Address(RVA = "0x17FBDDC", Offset = "0x17FBDDC", VA = "0x7BBBFFBDDC")]
		public void SetViewData(List<BaseItemInfo> itemList)
		{
		}

		// Token: 0x060083A7 RID: 33703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083A7")]
		[Address(RVA = "0x17FC1D8", Offset = "0x17FC1D8", VA = "0x7BBBFFC1D8")]
		public UIHudRewardListMatchResultController()
		{
		}

		// Token: 0x0400945D RID: 37981
		[Token(Token = "0x400945D")]
		[FieldOffset(Offset = "0x98")]
		private UIHudRewardListMatchResultPopWindowView m_View;

		// Token: 0x0400945E RID: 37982
		[Token(Token = "0x400945E")]
		[FieldOffset(Offset = "0xA0")]
		private List<MatchResultRewardItemView> m_ItemViewList;

		// Token: 0x02001954 RID: 6484
		[Token(Token = "0x2001954")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F605C", Offset = "0x10F605C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060083A9 RID: 33705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60083A9")]
			[Address(RVA = "0x17FC2AC", Offset = "0x17FC2AC", VA = "0x7BBBFFC2AC")]
			public <>c()
			{
			}

			// Token: 0x060083AA RID: 33706 RVA: 0x00023C28 File Offset: 0x00021E28
			[Token(Token = "0x60083AA")]
			[Address(RVA = "0x17FC2B4", Offset = "0x17FC2B4", VA = "0x7BBBFFC2B4")]
			internal int <SetViewData>b__4_0(BaseItemInfo a, BaseItemInfo b)
			{
				return 0;
			}

			// Token: 0x0400945F RID: 37983
			[Token(Token = "0x400945F")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudRewardListMatchResultController.<>c <>9;

			// Token: 0x04009460 RID: 37984
			[Token(Token = "0x4009460")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<BaseItemInfo> <>9__4_0;
		}
	}
}
