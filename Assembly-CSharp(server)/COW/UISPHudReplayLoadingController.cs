using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200160F RID: 5647
	[Token(Token = "0x200160F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF94C", Offset = "0x10EF94C")]
	public class UISPHudReplayLoadingController : UIBaseController
	{
		// Token: 0x0600653D RID: 25917 RVA: 0x0001CF80 File Offset: 0x0001B180
		[Token(Token = "0x600653D")]
		[Address(RVA = "0x1EF0530", Offset = "0x1EF0530", VA = "0x7BBC6F0530")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653E")]
		[Address(RVA = "0x1EF0580", Offset = "0x1EF0580", VA = "0x7BBC6F0580", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600653F RID: 25919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653F")]
		[Address(RVA = "0x1EF05E4", Offset = "0x1EF05E4", VA = "0x7BBC6F05E4")]
		public UISPHudReplayLoadingController()
		{
		}

		// Token: 0x040083AC RID: 33708
		[Token(Token = "0x40083AC")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudReplayLoadingView m_View;
	}
}
