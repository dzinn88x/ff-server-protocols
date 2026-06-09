using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200195E RID: 6494
	[Token(Token = "0x200195E")]
	public class UIHudSnowManIntroInfoController : UIBaseController
	{
		// Token: 0x060083F1 RID: 33777 RVA: 0x00023D60 File Offset: 0x00021F60
		[Token(Token = "0x60083F1")]
		[Address(RVA = "0x166C4AC", Offset = "0x166C4AC", VA = "0x7BBBE6C4AC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060083F2 RID: 33778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083F2")]
		[Address(RVA = "0x166C4FC", Offset = "0x166C4FC", VA = "0x7BBBE6C4FC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060083F3 RID: 33779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083F3")]
		[Address(RVA = "0x166C600", Offset = "0x166C600", VA = "0x7BBBE6C600", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060083F4 RID: 33780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083F4")]
		[Address(RVA = "0x166C6A8", Offset = "0x166C6A8", VA = "0x7BBBE6C6A8")]
		public UIHudSnowManIntroInfoController()
		{
		}

		// Token: 0x060083F5 RID: 33781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60083F5")]
		[Address(RVA = "0x166C6B0", Offset = "0x166C6B0", VA = "0x7BBBE6C6B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143364", Offset = "0x1143364")]
		private void <OnUIInit>b__3_0()
		{
		}

		// Token: 0x04009487 RID: 38023
		[Token(Token = "0x4009487")]
		[FieldOffset(Offset = "0x58")]
		private UIHudSnowManIntorInfoView m_View;

		// Token: 0x04009488 RID: 38024
		[Token(Token = "0x4009488")]
		[FieldOffset(Offset = "0x60")]
		private uint m_DelayCallId;
	}
}
