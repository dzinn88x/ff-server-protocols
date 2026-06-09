using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018F9 RID: 6393
	[Token(Token = "0x20018F9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F553C", Offset = "0x10F553C")]
	internal class UIHudJetFlyUpController : UIHudButtonBaseController
	{
		// Token: 0x06008051 RID: 32849 RVA: 0x00022FE0 File Offset: 0x000211E0
		[Token(Token = "0x6008051")]
		[Address(RVA = "0x1C4D14C", Offset = "0x1C4D14C", VA = "0x7BBC44D14C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008052 RID: 32850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008052")]
		[Address(RVA = "0x1C4D19C", Offset = "0x1C4D19C", VA = "0x7BBC44D19C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008053 RID: 32851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008053")]
		[Address(RVA = "0x1C4D218", Offset = "0x1C4D218", VA = "0x7BBC44D218", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008054 RID: 32852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008054")]
		[Address(RVA = "0x1C4D260", Offset = "0x1C4D260", VA = "0x7BBC44D260")]
		public UIHudJetFlyUpController()
		{
		}

		// Token: 0x04009295 RID: 37525
		[Token(Token = "0x4009295")]
		[FieldOffset(Offset = "0x60")]
		private UIHudJetFlyUpView m_View;
	}
}
