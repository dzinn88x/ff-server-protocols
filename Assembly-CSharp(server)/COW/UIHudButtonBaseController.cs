using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200188B RID: 6283
	[Token(Token = "0x200188B")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4534", Offset = "0x10F4534")]
	internal abstract class UIHudButtonBaseController : UIBaseController
	{
		// Token: 0x06007C62 RID: 31842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C62")]
		[Address(RVA = "0x19B5B54", Offset = "0x19B5B54", VA = "0x7BBC1B5B54", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007C63 RID: 31843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C63")]
		[Address(RVA = "0x19B5BE4", Offset = "0x19B5BE4", VA = "0x7BBC1B5BE4", Slot = "28")]
		protected virtual void OnBtnDown()
		{
		}

		// Token: 0x06007C64 RID: 31844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C64")]
		[Address(RVA = "0x19B5C74", Offset = "0x19B5C74", VA = "0x7BBC1B5C74", Slot = "29")]
		protected virtual void OnBtnUp()
		{
		}

		// Token: 0x06007C65 RID: 31845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C65")]
		[Address(RVA = "0x19B5D00", Offset = "0x19B5D00", VA = "0x7BBC1B5D00", Slot = "30")]
		protected virtual void OnBtnClick()
		{
		}

		// Token: 0x06007C66 RID: 31846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C66")]
		[Address(RVA = "0x19B5D04", Offset = "0x19B5D04", VA = "0x7BBC1B5D04", Slot = "31")]
		protected virtual void OnBtnPress()
		{
		}

		// Token: 0x06007C67 RID: 31847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C67")]
		[Address(RVA = "0x19B5D08", Offset = "0x19B5D08", VA = "0x7BBC1B5D08", Slot = "32")]
		protected virtual void OnBtnRelease()
		{
		}

		// Token: 0x06007C68 RID: 31848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C68")]
		[Address(RVA = "0x19B5D0C", Offset = "0x19B5D0C", VA = "0x7BBC1B5D0C", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007C69 RID: 31849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C69")]
		[Address(RVA = "0x19B5D40", Offset = "0x19B5D40", VA = "0x7BBC1B5D40")]
		protected void InitEventTrigger(UIButton button)
		{
		}

		// Token: 0x06007C6A RID: 31850
		[Token(Token = "0x6007C6A")]
		protected abstract string GetMappingName();

		// Token: 0x06007C6B RID: 31851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C6B")]
		[Address(RVA = "0x19B5F64", Offset = "0x19B5F64", VA = "0x7BBC1B5F64")]
		protected UIHudButtonBaseController()
		{
		}

		// Token: 0x0400905E RID: 36958
		[Token(Token = "0x400905E")]
		[FieldOffset(Offset = "0x58")]
		protected bool IsButtonDown;
	}
}
