using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020016F0 RID: 5872
	[Token(Token = "0x20016F0")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F114C", Offset = "0x10F114C")]
	public class UIChangeNamePopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06006CF7 RID: 27895 RVA: 0x0001EBB8 File Offset: 0x0001CDB8
		[Token(Token = "0x6006CF7")]
		[Address(RVA = "0x1EDE0C8", Offset = "0x1EDE0C8", VA = "0x7BBC6DE0C8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006CF8 RID: 27896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF8")]
		[Address(RVA = "0x1EDE118", Offset = "0x1EDE118", VA = "0x7BBC6DE118", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006CF9 RID: 27897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF9")]
		[Address(RVA = "0x1EDE358", Offset = "0x1EDE358", VA = "0x7BBC6DE358")]
		private void RefreshViewData()
		{
		}

		// Token: 0x06006CFA RID: 27898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CFA")]
		[Address(RVA = "0x1EDEBA4", Offset = "0x1EDEBA4", VA = "0x7BBC6DEBA4", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06006CFB RID: 27899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CFB")]
		[Address(RVA = "0x1EDE8B0", Offset = "0x1EDE8B0", VA = "0x7BBC6DE8B0")]
		private void OnInputChange()
		{
		}

		// Token: 0x06006CFC RID: 27900 RVA: 0x0001EBD0 File Offset: 0x0001CDD0
		[Token(Token = "0x6006CFC")]
		[Address(RVA = "0x1EDEC58", Offset = "0x1EDEC58", VA = "0x7BBC6DEC58")]
		private bool IsNameValid(string name)
		{
			return default(bool);
		}

		// Token: 0x06006CFD RID: 27901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CFD")]
		[Address(RVA = "0x1EDECC0", Offset = "0x1EDECC0", VA = "0x7BBC6DECC0")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06006CFE RID: 27902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CFE")]
		[Address(RVA = "0x1EDF1B8", Offset = "0x1EDF1B8", VA = "0x7BBC6DF1B8")]
		private void OnUseCardClick()
		{
		}

		// Token: 0x06006CFF RID: 27903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CFF")]
		[Address(RVA = "0x1EDF2EC", Offset = "0x1EDF2EC", VA = "0x7BBC6DF2EC", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006D00 RID: 27904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D00")]
		[Address(RVA = "0x1EDEED4", Offset = "0x1EDEED4", VA = "0x7BBC6DEED4")]
		private void ShowRenameDiamondShortHint()
		{
		}

		// Token: 0x06006D01 RID: 27905 RVA: 0x0001EBE8 File Offset: 0x0001CDE8
		[Token(Token = "0x6006D01")]
		[Address(RVA = "0x1EDF77C", Offset = "0x1EDF77C", VA = "0x7BBC6DF77C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006D02 RID: 27906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D02")]
		[Address(RVA = "0x1EDF7C0", Offset = "0x1EDF7C0", VA = "0x7BBC6DF7C0")]
		public UIChangeNamePopupWindowController()
		{
		}

		// Token: 0x04008865 RID: 34917
		[Token(Token = "0x4008865")]
		[FieldOffset(Offset = "0x98")]
		private UIChangeNamePopupWindowView m_View;

		// Token: 0x04008866 RID: 34918
		[Token(Token = "0x4008866")]
		private const uint BTN_DEFUALT_COLOR = 4294967295U;

		// Token: 0x04008867 RID: 34919
		[Token(Token = "0x4008867")]
		private const uint BTN_GREY_COLOR = 2593823487U;

		// Token: 0x04008868 RID: 34920
		[Token(Token = "0x4008868")]
		private const uint OUTLINE_BLUE = 192872447U;

		// Token: 0x04008869 RID: 34921
		[Token(Token = "0x4008869")]
		private const uint LABEL_GEM_COLOR = 188765951U;

		// Token: 0x0400886A RID: 34922
		[Token(Token = "0x400886A")]
		[FieldOffset(Offset = "0xA0")]
		private LoginRes m_UserData;

		// Token: 0x0400886B RID: 34923
		[Token(Token = "0x400886B")]
		[FieldOffset(Offset = "0xA8")]
		private RenameCostData m_CostData;

		// Token: 0x0400886C RID: 34924
		[Token(Token = "0x400886C")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_HasRequestedRename;

		// Token: 0x0400886D RID: 34925
		[Token(Token = "0x400886D")]
		[FieldOffset(Offset = "0xB8")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x020016F1 RID: 5873
		[Token(Token = "0x20016F1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F1184", Offset = "0x10F1184")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006D04 RID: 27908 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006D04")]
			[Address(RVA = "0x1BDDAAC", Offset = "0x1BDDAAC", VA = "0x7BBC3DDAAC")]
			public <>c()
			{
			}

			// Token: 0x06006D05 RID: 27909 RVA: 0x0001EC00 File Offset: 0x0001CE00
			[Token(Token = "0x6006D05")]
			[Address(RVA = "0x1BDDAB4", Offset = "0x1BDDAB4", VA = "0x7BBC3DDAB4")]
			internal bool <RefreshViewData>b__11_0(Item item)
			{
				return default(bool);
			}

			// Token: 0x06006D06 RID: 27910 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006D06")]
			[Address(RVA = "0x1BDDB6C", Offset = "0x1BDDB6C", VA = "0x7BBC3DDB6C")]
			internal void <ShowRenameDiamondShortHint>b__18_0()
			{
			}

			// Token: 0x0400886E RID: 34926
			[Token(Token = "0x400886E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIChangeNamePopupWindowController.<>c <>9;

			// Token: 0x0400886F RID: 34927
			[Token(Token = "0x400886F")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<Item> <>9__11_0;

			// Token: 0x04008870 RID: 34928
			[Token(Token = "0x4008870")]
			[FieldOffset(Offset = "0x10")]
			public static Action <>9__18_0;
		}
	}
}
