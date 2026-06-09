using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A79 RID: 6777
	[Token(Token = "0x2001A79")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F840C", Offset = "0x10F840C")]
	public class UIModifyClanNameController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06008EC0 RID: 36544 RVA: 0x00026100 File Offset: 0x00024300
		[Token(Token = "0x6008EC0")]
		[Address(RVA = "0x14C6004", Offset = "0x14C6004", VA = "0x7BBBCC6004")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008EC1 RID: 36545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EC1")]
		[Address(RVA = "0x14C6054", Offset = "0x14C6054", VA = "0x7BBBCC6054", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008EC2 RID: 36546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EC2")]
		[Address(RVA = "0x14C6260", Offset = "0x14C6260", VA = "0x7BBBCC6260")]
		private void RefreshViewData()
		{
		}

		// Token: 0x06008EC3 RID: 36547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EC3")]
		[Address(RVA = "0x14C66D0", Offset = "0x14C66D0", VA = "0x7BBBCC66D0", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06008EC4 RID: 36548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EC4")]
		[Address(RVA = "0x14C659C", Offset = "0x14C659C", VA = "0x7BBBCC659C")]
		private void OnInputChange()
		{
		}

		// Token: 0x06008EC5 RID: 36549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EC5")]
		[Address(RVA = "0x14C6784", Offset = "0x14C6784", VA = "0x7BBBCC6784")]
		private void OnConfirmClick()
		{
		}

		// Token: 0x06008EC6 RID: 36550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EC6")]
		[Address(RVA = "0x14C6EB0", Offset = "0x14C6EB0", VA = "0x7BBBCC6EB0", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06008EC7 RID: 36551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EC7")]
		[Address(RVA = "0x14C6BCC", Offset = "0x14C6BCC", VA = "0x7BBBCC6BCC")]
		private void ShowRenameDiamondShortHint()
		{
		}

		// Token: 0x06008EC8 RID: 36552 RVA: 0x00026118 File Offset: 0x00024318
		[Token(Token = "0x6008EC8")]
		[Address(RVA = "0x14C70C4", Offset = "0x14C70C4", VA = "0x7BBBCC70C4", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06008EC9 RID: 36553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EC9")]
		[Address(RVA = "0x14C7108", Offset = "0x14C7108", VA = "0x7BBBCC7108")]
		public UIModifyClanNameController()
		{
		}

		// Token: 0x04009A56 RID: 39510
		[Token(Token = "0x4009A56")]
		private const uint BTN_DEFUALT_COLOR = 1608186111U;

		// Token: 0x04009A57 RID: 39511
		[Token(Token = "0x4009A57")]
		private const uint BTN_GREY_COLOR = 2593823487U;

		// Token: 0x04009A58 RID: 39512
		[Token(Token = "0x4009A58")]
		[FieldOffset(Offset = "0x98")]
		private UIModifyClanNameView m_View;

		// Token: 0x04009A59 RID: 39513
		[Token(Token = "0x4009A59")]
		[FieldOffset(Offset = "0xA0")]
		private ClanRenameData m_CostData;

		// Token: 0x04009A5A RID: 39514
		[Token(Token = "0x4009A5A")]
		[FieldOffset(Offset = "0xA8")]
		private string m_ClanName;

		// Token: 0x04009A5B RID: 39515
		[Token(Token = "0x4009A5B")]
		private const int NAME_MIN_LENGTH = 3;

		// Token: 0x04009A5C RID: 39516
		[Token(Token = "0x4009A5C")]
		private const int NAME_MAX_LENGTH = 12;

		// Token: 0x02001A7A RID: 6778
		[Token(Token = "0x2001A7A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F8444", Offset = "0x10F8444")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06008ECB RID: 36555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008ECB")]
			[Address(RVA = "0x14C7174", Offset = "0x14C7174", VA = "0x7BBBCC7174")]
			public <>c()
			{
			}

			// Token: 0x06008ECC RID: 36556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008ECC")]
			[Address(RVA = "0x14C717C", Offset = "0x14C717C", VA = "0x7BBBCC717C")]
			internal void <ShowRenameDiamondShortHint>b__14_0()
			{
			}

			// Token: 0x04009A5D RID: 39517
			[Token(Token = "0x4009A5D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModifyClanNameController.<>c <>9;

			// Token: 0x04009A5E RID: 39518
			[Token(Token = "0x4009A5E")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__14_0;
		}
	}
}
