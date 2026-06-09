using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001A9B RID: 6811
	[Token(Token = "0x2001A9B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F867C", Offset = "0x10F867C")]
	public class UINewPlayerPathController : UIBaseController
	{
		// Token: 0x06008F88 RID: 36744 RVA: 0x000263A0 File Offset: 0x000245A0
		[Token(Token = "0x6008F88")]
		[Address(RVA = "0x1AF4830", Offset = "0x1AF4830", VA = "0x7BBC2F4830")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F89")]
		[Address(RVA = "0x1AF4880", Offset = "0x1AF4880", VA = "0x7BBC2F4880", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F8A")]
		[Address(RVA = "0x1AF50BC", Offset = "0x1AF50BC", VA = "0x7BBC2F50BC", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x000263B8 File Offset: 0x000245B8
		[Token(Token = "0x6008F8B")]
		[Address(RVA = "0x1AF50C4", Offset = "0x1AF50C4", VA = "0x7BBC2F50C4")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F8C")]
		[Address(RVA = "0x1AF4B7C", Offset = "0x1AF4B7C", VA = "0x7BBC2F4B7C")]
		private void CreateItems()
		{
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F8D")]
		[Address(RVA = "0x1AF52F4", Offset = "0x1AF52F4", VA = "0x7BBC2F52F4")]
		public void OpenDetail(int index, bool toOpen = true)
		{
		}

		// Token: 0x06008F8E RID: 36750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F8E")]
		[Address(RVA = "0x1AF5620", Offset = "0x1AF5620", VA = "0x7BBC2F5620")]
		private void ScrollTo(Vector3 pos)
		{
		}

		// Token: 0x06008F8F RID: 36751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F8F")]
		[Address(RVA = "0x1AF5890", Offset = "0x1AF5890", VA = "0x7BBC2F5890")]
		public UINewPlayerPathController()
		{
		}

		// Token: 0x06008F90 RID: 36752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008F90")]
		[Address(RVA = "0x1AF5900", Offset = "0x1AF5900", VA = "0x7BBC2F5900")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11447B8", Offset = "0x11447B8")]
		private void <OnUIInit>b__7_0()
		{
		}

		// Token: 0x04009BB3 RID: 39859
		[Token(Token = "0x4009BB3")]
		[FieldOffset(Offset = "0x58")]
		private UIModelNewPlayerPath m_PathModel;

		// Token: 0x04009BB4 RID: 39860
		[Token(Token = "0x4009BB4")]
		[FieldOffset(Offset = "0x60")]
		private UINewPlayerPathView m_View;

		// Token: 0x04009BB5 RID: 39861
		[Token(Token = "0x4009BB5")]
		[FieldOffset(Offset = "0x68")]
		private UINewPlayerPathDetailController m_CurDetail;

		// Token: 0x04009BB6 RID: 39862
		[Token(Token = "0x4009BB6")]
		[FieldOffset(Offset = "0x70")]
		private List<UINewPlayerPathItemController> m_PathItems;

		// Token: 0x04009BB7 RID: 39863
		[Token(Token = "0x4009BB7")]
		[FieldOffset(Offset = "0x78")]
		private UICountDownController m_CountDownCtrl;

		// Token: 0x04009BB8 RID: 39864
		[Token(Token = "0x4009BB8")]
		[FieldOffset(Offset = "0x80")]
		public bool m_HasOpenDetailed;

		// Token: 0x02001A9C RID: 6812
		[Token(Token = "0x2001A9C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F86B4", Offset = "0x10F86B4")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06008F91 RID: 36753 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008F91")]
			[Address(RVA = "0x1AF5108", Offset = "0x1AF5108", VA = "0x7BBC2F5108")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06008F92 RID: 36754 RVA: 0x000263D0 File Offset: 0x000245D0
			[Token(Token = "0x6008F92")]
			[Address(RVA = "0x1AF595C", Offset = "0x1AF595C", VA = "0x7BBC2F595C")]
			internal bool <CreateItems>b__0(ActivityInfo temp)
			{
				return default(bool);
			}

			// Token: 0x04009BB9 RID: 39865
			[Token(Token = "0x4009BB9")]
			[FieldOffset(Offset = "0x10")]
			public NewPlayerSevenDaysAwardData conf;
		}
	}
}
