using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001C0E RID: 7182
	[Token(Token = "0x2001C0E")]
	internal class UIWereWolvesRoomSetting : UIHUDWereWolvesCreateRoom
	{
		// Token: 0x06009C6A RID: 40042 RVA: 0x000290A0 File Offset: 0x000272A0
		[Token(Token = "0x6009C6A")]
		[Address(RVA = "0x179201C", Offset = "0x179201C", VA = "0x7BBBF9201C")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009C6B RID: 40043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C6B")]
		[Address(RVA = "0x179206C", Offset = "0x179206C", VA = "0x7BBBF9206C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009C6C RID: 40044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C6C")]
		[Address(RVA = "0x1792108", Offset = "0x1792108", VA = "0x7BBBF92108", Slot = "40")]
		protected override void InitDefaultParams()
		{
		}

		// Token: 0x06009C6D RID: 40045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C6D")]
		[Address(RVA = "0x1792268", Offset = "0x1792268", VA = "0x7BBBF92268", Slot = "43")]
		protected override void OnLanguageBtnClick()
		{
		}

		// Token: 0x06009C6E RID: 40046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C6E")]
		[Address(RVA = "0x179226C", Offset = "0x179226C", VA = "0x7BBBF9226C", Slot = "42")]
		protected override void InitPlayerCountUIComponent()
		{
		}

		// Token: 0x06009C6F RID: 40047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C6F")]
		[Address(RVA = "0x17923B4", Offset = "0x17923B4", VA = "0x7BBBF923B4", Slot = "41")]
		protected override void InitLanguageUIComponent()
		{
		}

		// Token: 0x06009C70 RID: 40048 RVA: 0x000290B8 File Offset: 0x000272B8
		[Token(Token = "0x6009C70")]
		[Address(RVA = "0x1792404", Offset = "0x1792404", VA = "0x7BBBF92404", Slot = "44")]
		protected override bool NeedCheckRoomCard()
		{
			return default(bool);
		}

		// Token: 0x06009C71 RID: 40049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C71")]
		[Address(RVA = "0x179240C", Offset = "0x179240C", VA = "0x7BBBF9240C", Slot = "46")]
		protected override void ProcessConfirmRoomInfo()
		{
		}

		// Token: 0x06009C72 RID: 40050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C72")]
		[Address(RVA = "0x1792728", Offset = "0x1792728", VA = "0x7BBBF92728")]
		public UIWereWolvesRoomSetting()
		{
		}

		// Token: 0x0400A238 RID: 41528
		[Token(Token = "0x400A238")]
		[FieldOffset(Offset = "0x118")]
		private ulong m_RoomID;

		// Token: 0x0400A239 RID: 41529
		[Token(Token = "0x400A239")]
		[FieldOffset(Offset = "0x120")]
		private UIModelCustomRoom m_Model;
	}
}
