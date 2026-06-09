using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BC2 RID: 7106
	[Token(Token = "0x2001BC2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FACBC", Offset = "0x10FACBC")]
	internal class UIUnLockSkillSlotWindowController : UIPopupWindowController
	{
		// Token: 0x0600999A RID: 39322 RVA: 0x000286F8 File Offset: 0x000268F8
		[Token(Token = "0x600999A")]
		[Address(RVA = "0x19FAFC8", Offset = "0x19FAFC8", VA = "0x7BBC1FAFC8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600999B RID: 39323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600999B")]
		[Address(RVA = "0x19FB018", Offset = "0x19FB018", VA = "0x7BBC1FB018", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600999C RID: 39324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600999C")]
		[Address(RVA = "0x19FB154", Offset = "0x19FB154", VA = "0x7BBC1FB154", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600999D RID: 39325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600999D")]
		[Address(RVA = "0x19FB15C", Offset = "0x19FB15C", VA = "0x7BBC1FB15C")]
		private void OnBtnCoinsBuy()
		{
		}

		// Token: 0x0600999E RID: 39326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600999E")]
		[Address(RVA = "0x19FB46C", Offset = "0x19FB46C", VA = "0x7BBC1FB46C")]
		private void OnBtnGemsBuy()
		{
		}

		// Token: 0x0600999F RID: 39327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600999F")]
		[Address(RVA = "0x19FB5E4", Offset = "0x19FB5E4", VA = "0x7BBC1FB5E4")]
		public void UpdateDate(int _slotIndex, uint _avatarID)
		{
		}

		// Token: 0x060099A0 RID: 39328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60099A0")]
		[Address(RVA = "0x19FB9AC", Offset = "0x19FB9AC", VA = "0x7BBC1FB9AC")]
		public UIUnLockSkillSlotWindowController()
		{
		}

		// Token: 0x0400A0CC RID: 41164
		[Token(Token = "0x400A0CC")]
		[FieldOffset(Offset = "0x98")]
		private UIUnLockSkillSlotWindowView m_View;

		// Token: 0x0400A0CD RID: 41165
		[Token(Token = "0x400A0CD")]
		[FieldOffset(Offset = "0xA0")]
		private uint avaterID;

		// Token: 0x0400A0CE RID: 41166
		[Token(Token = "0x400A0CE")]
		[FieldOffset(Offset = "0xA4")]
		private int slotIndex;

		// Token: 0x0400A0CF RID: 41167
		[Token(Token = "0x400A0CF")]
		[FieldOffset(Offset = "0xA8")]
		private int skillID;

		// Token: 0x0400A0D0 RID: 41168
		[Token(Token = "0x400A0D0")]
		[FieldOffset(Offset = "0xAC")]
		private int gemCount;

		// Token: 0x0400A0D1 RID: 41169
		[Token(Token = "0x400A0D1")]
		[FieldOffset(Offset = "0xB0")]
		private int coinCount;
	}
}
