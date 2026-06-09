using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001511 RID: 5393
	[Token(Token = "0x2001511")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EE0E4", Offset = "0x10EE0E4")]
	public class UIHudModeIntroInfoController : UIBaseController
	{
		// Token: 0x06005CA7 RID: 23719 RVA: 0x0001AF70 File Offset: 0x00019170
		[Token(Token = "0x6005CA7")]
		[Address(RVA = "0x17B4228", Offset = "0x17B4228", VA = "0x7BBBFB4228")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005CA8 RID: 23720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA8")]
		[Address(RVA = "0x17B4418", Offset = "0x17B4418", VA = "0x7BBBFB4418", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA9")]
		[Address(RVA = "0x17B4504", Offset = "0x17B4504", VA = "0x7BBBFB4504", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAA")]
		[Address(RVA = "0x17B45AC", Offset = "0x17B45AC", VA = "0x7BBBFB45AC")]
		public UIHudModeIntroInfoController()
		{
		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAB")]
		[Address(RVA = "0x17B45B4", Offset = "0x17B45B4", VA = "0x7BBBFB45B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F8C4", Offset = "0x113F8C4")]
		private void <OnUIInit>b__2_0()
		{
		}

		// Token: 0x04007EBA RID: 32442
		[Token(Token = "0x4007EBA")]
		[FieldOffset(Offset = "0x58")]
		private uint m_DelayCallId;
	}
}
