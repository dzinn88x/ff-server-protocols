using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CAD RID: 7341
	[Token(Token = "0x2001CAD")]
	public class AvatarProfileDataManager : SingletonModule<AvatarProfileDataManager>, IUIModelDataChangeObserver
	{
		// Token: 0x0600A032 RID: 41010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A032")]
		[Address(RVA = "0x1564D20", Offset = "0x1564D20", VA = "0x7BBBD64D20", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A033 RID: 41011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A033")]
		[Address(RVA = "0x1564FEC", Offset = "0x1564FEC", VA = "0x7BBBD64FEC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A034 RID: 41012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A034")]
		[Address(RVA = "0x1564FF4", Offset = "0x1564FF4", VA = "0x7BBBD64FF4")]
		public void ClearData()
		{
		}

		// Token: 0x0600A035 RID: 41013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A035")]
		[Address(RVA = "0x1564FFC", Offset = "0x1564FFC", VA = "0x7BBBD64FFC", Slot = "10")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600A036 RID: 41014 RVA: 0x00029EF8 File Offset: 0x000280F8
		[Token(Token = "0x600A036")]
		[Address(RVA = "0x156546C", Offset = "0x156546C", VA = "0x7BBBD6546C", Slot = "11")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600A037 RID: 41015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A037")]
		[Address(RVA = "0x15654D0", Offset = "0x15654D0", VA = "0x7BBBD654D0")]
		public AvatarProfileDataManager()
		{
		}

		// Token: 0x0400A71E RID: 42782
		[Token(Token = "0x400A71E")]
		[FieldOffset(Offset = "0x18")]
		private UIModelAvatarProfile m_ModelAvatarProfile;

		// Token: 0x0400A71F RID: 42783
		[Token(Token = "0x400A71F")]
		[FieldOffset(Offset = "0x20")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x0400A720 RID: 42784
		[Token(Token = "0x400A720")]
		[FieldOffset(Offset = "0x28")]
		private UIModelAvatar m_ModelAvatar;

		// Token: 0x0400A721 RID: 42785
		[Token(Token = "0x400A721")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IsBackpackReady;

		// Token: 0x0400A722 RID: 42786
		[Token(Token = "0x400A722")]
		[FieldOffset(Offset = "0x31")]
		private bool m_IsAvatarInfoReady;
	}
}
