using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200191E RID: 6430
	[Token(Token = "0x200191E")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5944", Offset = "0x10F5944")]
	public class UIHudOBInfoController : UIBaseController
	{
		// Token: 0x060081C4 RID: 33220 RVA: 0x00023610 File Offset: 0x00021810
		[Token(Token = "0x60081C4")]
		[Address(RVA = "0x17BC5B4", Offset = "0x17BC5B4", VA = "0x7BBBFBC5B4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060081C5 RID: 33221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081C5")]
		[Address(RVA = "0x17BC604", Offset = "0x17BC604", VA = "0x7BBBFBC604", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060081C6 RID: 33222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081C6")]
		[Address(RVA = "0x17BC714", Offset = "0x17BC714", VA = "0x7BBBFBC714", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060081C7 RID: 33223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081C7")]
		[Address(RVA = "0x17BC7D4", Offset = "0x17BC7D4", VA = "0x7BBBFBC7D4")]
		private void OnTeamFinisheGame(params object[] data)
		{
		}

		// Token: 0x060081C8 RID: 33224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081C8")]
		[Address(RVA = "0x17BC818", Offset = "0x17BC818", VA = "0x7BBBFBC818")]
		public UIHudOBInfoController()
		{
		}

		// Token: 0x04009353 RID: 37715
		[Token(Token = "0x4009353")]
		[FieldOffset(Offset = "0x58")]
		private UIHudOBInfoView m_View;
	}
}
