using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018F7 RID: 6391
	[Token(Token = "0x20018F7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F54CC", Offset = "0x10F54CC")]
	internal class UIHudJetFlyController : UIHudButtonBaseController
	{
		// Token: 0x06008046 RID: 32838 RVA: 0x00022FB0 File Offset: 0x000211B0
		[Token(Token = "0x6008046")]
		[Address(RVA = "0x1C4C724", Offset = "0x1C4C724", VA = "0x7BBC44C724")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008047")]
		[Address(RVA = "0x1C4C774", Offset = "0x1C4C774", VA = "0x7BBC44C774", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008048 RID: 32840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008048")]
		[Address(RVA = "0x1C4C8D4", Offset = "0x1C4C8D4", VA = "0x7BBC44C8D4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008049 RID: 32841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008049")]
		[Address(RVA = "0x1C4C9A0", Offset = "0x1C4C9A0", VA = "0x7BBC44C9A0", Slot = "33")]
		protected override string GetMappingName()
		{
			return null;
		}

		// Token: 0x0600804A RID: 32842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600804A")]
		[Address(RVA = "0x1C4C9E8", Offset = "0x1C4C9E8", VA = "0x7BBC44C9E8")]
		private void Update()
		{
		}

		// Token: 0x0600804B RID: 32843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600804B")]
		[Address(RVA = "0x1C4CDD8", Offset = "0x1C4CDD8", VA = "0x7BBC44CDD8")]
		private void OnEnergyChange(params object[] data)
		{
		}

		// Token: 0x0600804C RID: 32844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600804C")]
		[Address(RVA = "0x1C4CF00", Offset = "0x1C4CF00", VA = "0x7BBC44CF00")]
		public UIHudJetFlyController()
		{
		}

		// Token: 0x04009293 RID: 37523
		[Token(Token = "0x4009293")]
		[FieldOffset(Offset = "0x60")]
		private UIHudJetFlyView m_View;
	}
}
