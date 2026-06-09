using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200161C RID: 5660
	[Token(Token = "0x200161C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFB1C", Offset = "0x10EFB1C")]
	public class UIHudCommonPregameTimeTipController : UIBaseController
	{
		// Token: 0x060065B5 RID: 26037 RVA: 0x0001D100 File Offset: 0x0001B300
		[Token(Token = "0x60065B5")]
		[Address(RVA = "0x1A91594", Offset = "0x1A91594", VA = "0x7BBC291594")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B6")]
		[Address(RVA = "0x1A915E4", Offset = "0x1A915E4", VA = "0x7BBC2915E4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060065B7 RID: 26039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B7")]
		[Address(RVA = "0x1A91648", Offset = "0x1A91648", VA = "0x7BBC291648")]
		private void Update()
		{
		}

		// Token: 0x060065B8 RID: 26040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B8")]
		[Address(RVA = "0x1A91A28", Offset = "0x1A91A28", VA = "0x7BBC291A28")]
		public UIHudCommonPregameTimeTipController()
		{
		}

		// Token: 0x040083D5 RID: 33749
		[Token(Token = "0x40083D5")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCommonPregameTimeTipView m_View;

		// Token: 0x040083D6 RID: 33750
		[Token(Token = "0x40083D6")]
		[FieldOffset(Offset = "0x60")]
		private int lastLeftTimeS;
	}
}
