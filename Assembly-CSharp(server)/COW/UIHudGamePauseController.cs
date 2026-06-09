using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018C7 RID: 6343
	[Token(Token = "0x20018C7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4CFC", Offset = "0x10F4CFC")]
	internal class UIHudGamePauseController : UIBaseController
	{
		// Token: 0x06007E54 RID: 32340 RVA: 0x000228C0 File Offset: 0x00020AC0
		[Token(Token = "0x6007E54")]
		[Address(RVA = "0x1C12E20", Offset = "0x1C12E20", VA = "0x7BBC412E20")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E55")]
		[Address(RVA = "0x1C12E70", Offset = "0x1C12E70", VA = "0x7BBC412E70", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E56")]
		[Address(RVA = "0x1C12ED4", Offset = "0x1C12ED4", VA = "0x7BBC412ED4")]
		public void Pause()
		{
		}

		// Token: 0x06007E57 RID: 32343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E57")]
		[Address(RVA = "0x1C1309C", Offset = "0x1C1309C", VA = "0x7BBC41309C")]
		public void PreResume(byte time)
		{
		}

		// Token: 0x06007E58 RID: 32344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E58")]
		[Address(RVA = "0x1C13264", Offset = "0x1C13264", VA = "0x7BBC413264")]
		protected void FixedUpdate()
		{
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E59")]
		[Address(RVA = "0x1C133B0", Offset = "0x1C133B0", VA = "0x7BBC4133B0")]
		public UIHudGamePauseController()
		{
		}

		// Token: 0x040091B5 RID: 37301
		[Token(Token = "0x40091B5")]
		[FieldOffset(Offset = "0x58")]
		private UIHudGamePauseView m_View;

		// Token: 0x040091B6 RID: 37302
		[Token(Token = "0x40091B6")]
		[FieldOffset(Offset = "0x60")]
		private float m_CountDownTime;
	}
}
