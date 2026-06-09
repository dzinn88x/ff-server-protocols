using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001644 RID: 5700
	[Token(Token = "0x2001644")]
	public class UIHudReaperIntroInfoController : UIBaseController
	{
		// Token: 0x060066DA RID: 26330 RVA: 0x0001D568 File Offset: 0x0001B768
		[Token(Token = "0x60066DA")]
		[Address(RVA = "0x17EA200", Offset = "0x17EA200", VA = "0x7BBBFEA200")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060066DB RID: 26331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DB")]
		[Address(RVA = "0x17EA250", Offset = "0x17EA250", VA = "0x7BBBFEA250", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060066DC RID: 26332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DC")]
		[Address(RVA = "0x17EA520", Offset = "0x17EA520", VA = "0x7BBBFEA520", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060066DD RID: 26333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DD")]
		[Address(RVA = "0x17EA5C8", Offset = "0x17EA5C8", VA = "0x7BBBFEA5C8")]
		public UIHudReaperIntroInfoController()
		{
		}

		// Token: 0x060066DE RID: 26334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066DE")]
		[Address(RVA = "0x17EA5D0", Offset = "0x17EA5D0", VA = "0x7BBBFEA5D0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11408F0", Offset = "0x11408F0")]
		private void <OnUIInit>b__3_0()
		{
		}

		// Token: 0x04008470 RID: 33904
		[Token(Token = "0x4008470")]
		[FieldOffset(Offset = "0x58")]
		private UIHudReaperIntroInfoView m_View;

		// Token: 0x04008471 RID: 33905
		[Token(Token = "0x4008471")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallId;
	}
}
