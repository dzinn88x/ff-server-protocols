using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018F8 RID: 6392
	[Token(Token = "0x20018F8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5504", Offset = "0x10F5504")]
	internal class UIHudJetFlyDownController : UIHudButtonBaseController
	{
		// Token: 0x0600804D RID: 32845 RVA: 0x00022FC8 File Offset: 0x000211C8
		[Token(Token = "0x600804D")]
		[Address(RVA = "0x1C4CF08", Offset = "0x1C4CF08", VA = "0x7BBC44CF08")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600804E RID: 32846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600804E")]
		[Address(RVA = "0x1C4CF58", Offset = "0x1C4CF58", VA = "0x7BBC44CF58", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600804F RID: 32847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600804F")]
		[Address(RVA = "0x1C4CFD4", Offset = "0x1C4CFD4", VA = "0x7BBC44CFD4", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x06008050 RID: 32848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008050")]
		[Address(RVA = "0x1C4D01C", Offset = "0x1C4D01C", VA = "0x7BBC44D01C")]
		public UIHudJetFlyDownController()
		{
		}

		// Token: 0x04009294 RID: 37524
		[Token(Token = "0x4009294")]
		[FieldOffset(Offset = "0x60")]
		private UIHudJetFlyDownView m_View;
	}
}
