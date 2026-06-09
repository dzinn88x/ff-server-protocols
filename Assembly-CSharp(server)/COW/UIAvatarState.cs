using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001453 RID: 5203
	[Token(Token = "0x2001453")]
	public class UIAvatarState : UIAvatarStateBase
	{
		// Token: 0x06005741 RID: 22337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005741")]
		[Address(RVA = "0x1E5087C", Offset = "0x1E5087C", VA = "0x7BBC65087C")]
		public void CloneTo(UIAvatarState s)
		{
		}

		// Token: 0x06005742 RID: 22338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005742")]
		[Address(RVA = "0x1E50998", Offset = "0x1E50998", VA = "0x7BBC650998", Slot = "4")]
		public override void ResetOnceValues()
		{
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005743")]
		[Address(RVA = "0x1E509A8", Offset = "0x1E509A8", VA = "0x7BBC6509A8")]
		public UIAvatarState()
		{
		}

		// Token: 0x04007B8F RID: 31631
		[Token(Token = "0x4007B8F")]
		[FieldOffset(Offset = "0x48")]
		public UIAvatarStateTriggerValue<uint> CurrentSelectClothes;

		// Token: 0x04007B90 RID: 31632
		[Token(Token = "0x4007B90")]
		[FieldOffset(Offset = "0x50")]
		public bool HidingSet;

		// Token: 0x04007B91 RID: 31633
		[Token(Token = "0x4007B91")]
		[FieldOffset(Offset = "0x58")]
		public string HidingSlot;
	}
}
