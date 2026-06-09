using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001BBF RID: 7103
	[Token(Token = "0x2001BBF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAC14", Offset = "0x10FAC14")]
	public class UITurntableSigninItemController : UIBaseController
	{
		// Token: 0x06009986 RID: 39302 RVA: 0x00028698 File Offset: 0x00026898
		[Token(Token = "0x6009986")]
		[Address(RVA = "0x19F7188", Offset = "0x19F7188", VA = "0x7BBC1F7188")]
		public uint GetSignID()
		{
			return 0U;
		}

		// Token: 0x06009987 RID: 39303 RVA: 0x000286B0 File Offset: 0x000268B0
		[Token(Token = "0x6009987")]
		[Address(RVA = "0x19F7344", Offset = "0x19F7344", VA = "0x7BBC1F7344")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009988 RID: 39304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009988")]
		[Address(RVA = "0x19F7394", Offset = "0x19F7394", VA = "0x7BBC1F7394", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009989 RID: 39305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009989")]
		[Address(RVA = "0x19F5A10", Offset = "0x19F5A10", VA = "0x7BBC1F5A10")]
		public void SetData(AttendanceItem info)
		{
		}

		// Token: 0x0600998A RID: 39306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600998A")]
		[Address(RVA = "0x19F77D8", Offset = "0x19F77D8", VA = "0x7BBC1F77D8")]
		private void SetQualityBG()
		{
		}

		// Token: 0x0600998B RID: 39307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600998B")]
		[Address(RVA = "0x19F7478", Offset = "0x19F7478", VA = "0x7BBC1F7478")]
		private void RefreshSignState()
		{
		}

		// Token: 0x0600998C RID: 39308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600998C")]
		[Address(RVA = "0x19F7AB0", Offset = "0x19F7AB0", VA = "0x7BBC1F7AB0")]
		private void ShowBigRewardEffect()
		{
		}

		// Token: 0x0600998D RID: 39309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600998D")]
		[Address(RVA = "0x19F5E04", Offset = "0x19F5E04", VA = "0x7BBC1F5E04")]
		public void Signed()
		{
		}

		// Token: 0x0600998E RID: 39310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600998E")]
		[Address(RVA = "0x19F604C", Offset = "0x19F604C", VA = "0x7BBC1F604C")]
		public void ShowGetRewardEffect()
		{
		}

		// Token: 0x0600998F RID: 39311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600998F")]
		[Address(RVA = "0x19F7B24", Offset = "0x19F7B24", VA = "0x7BBC1F7B24")]
		private void OnItemBtnClick()
		{
		}

		// Token: 0x06009990 RID: 39312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009990")]
		[Address(RVA = "0x19F7CE8", Offset = "0x19F7CE8", VA = "0x7BBC1F7CE8")]
		public UITurntableSigninItemController()
		{
		}

		// Token: 0x0400A0C6 RID: 41158
		[Token(Token = "0x400A0C6")]
		[FieldOffset(Offset = "0x58")]
		private UITurntableSignInItemView m_View;

		// Token: 0x0400A0C7 RID: 41159
		[Token(Token = "0x400A0C7")]
		[FieldOffset(Offset = "0x60")]
		private AttendanceItem m_ItemInfo;

		// Token: 0x0400A0C8 RID: 41160
		[Token(Token = "0x400A0C8")]
		[FieldOffset(Offset = "0x68")]
		private BaseItemInfo m_BaseItemInfo;

		// Token: 0x0400A0C9 RID: 41161
		[Token(Token = "0x400A0C9")]
		private const uint CLAIMEDCOLOR = 1886417151U;
	}
}
