using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200142A RID: 5162
	[Token(Token = "0x200142A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC8C8", Offset = "0x10EC8C8")]
	public class UIHUDArmsRaceTopLevelWarningController : UIBaseController
	{
		// Token: 0x0600555B RID: 21851 RVA: 0x00019710 File Offset: 0x00017910
		[Token(Token = "0x600555B")]
		[Address(RVA = "0x16B54C0", Offset = "0x16B54C0", VA = "0x7BBBEB54C0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555C")]
		[Address(RVA = "0x16B5510", Offset = "0x16B5510", VA = "0x7BBBEB5510", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555D")]
		[Address(RVA = "0x16B5674", Offset = "0x16B5674", VA = "0x7BBBEB5674", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555E")]
		[Address(RVA = "0x16B5794", Offset = "0x16B5794", VA = "0x7BBBEB5794")]
		private void OnOtherIsTopLevel(params object[] param)
		{
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555F")]
		[Address(RVA = "0x16B5A90", Offset = "0x16B5A90", VA = "0x7BBBEB5A90")]
		private void OnTeamIsTopLevel(params object[] param)
		{
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005560")]
		[Address(RVA = "0x16B5938", Offset = "0x16B5938", VA = "0x7BBBEB5938")]
		private void ShowWarning(string showInfo)
		{
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005561")]
		[Address(RVA = "0x16B5C5C", Offset = "0x16B5C5C", VA = "0x7BBBEB5C5C")]
		public UIHUDArmsRaceTopLevelWarningController()
		{
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005562")]
		[Address(RVA = "0x16B5C64", Offset = "0x16B5C64", VA = "0x7BBBEB5C64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E8F0", Offset = "0x113E8F0")]
		private void <ShowWarning>b__7_0()
		{
		}

		// Token: 0x04007A4E RID: 31310
		[Token(Token = "0x4007A4E")]
		[FieldOffset(Offset = "0x58")]
		private UIHUDArmsRaceTopLevelWarningView m_View;

		// Token: 0x04007A4F RID: 31311
		[Token(Token = "0x4007A4F")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallID;
	}
}
