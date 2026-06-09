using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020017E6 RID: 6118
	[Token(Token = "0x20017E6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F3044", Offset = "0x10F3044")]
	internal class UIGachaEnergyContent : UIGachaContentBase
	{
		// Token: 0x06007660 RID: 30304 RVA: 0x00020D18 File Offset: 0x0001EF18
		[Token(Token = "0x6007660")]
		[Address(RVA = "0x2161768", Offset = "0x2161768", VA = "0x7BBC961768")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007661 RID: 30305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007661")]
		[Address(RVA = "0x21617B8", Offset = "0x21617B8", VA = "0x7BBC9617B8", Slot = "50")]
		public override string GetTutorialWndTitleKey()
		{
			return null;
		}

		// Token: 0x06007662 RID: 30306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007662")]
		[Address(RVA = "0x2161808", Offset = "0x2161808", VA = "0x7BBC961808", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007663")]
		[Address(RVA = "0x2161A2C", Offset = "0x2161A2C", VA = "0x7BBC961A2C", Slot = "30")]
		protected override void InitGachaContentBuyBtn()
		{
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007664")]
		[Address(RVA = "0x2161AF0", Offset = "0x2161AF0", VA = "0x7BBC961AF0", Slot = "31")]
		protected override void OnRefreshUIView()
		{
		}

		// Token: 0x06007665 RID: 30309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007665")]
		[Address(RVA = "0x2161BEC", Offset = "0x2161BEC", VA = "0x7BBC961BEC", Slot = "49")]
		public override UIGachaPreviewController OpenPreviewPanel(Transform parent)
		{
			return null;
		}

		// Token: 0x06007666 RID: 30310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007666")]
		[Address(RVA = "0x2161C80", Offset = "0x2161C80", VA = "0x7BBC961C80")]
		private void OnClickShowRewardsBtn()
		{
		}

		// Token: 0x06007667 RID: 30311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007667")]
		[Address(RVA = "0x2161F5C", Offset = "0x2161F5C", VA = "0x7BBC961F5C")]
		private void OnClickChooseCheckbtn()
		{
		}

		// Token: 0x06007668 RID: 30312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007668")]
		[Address(RVA = "0x216204C", Offset = "0x216204C", VA = "0x7BBC96204C")]
		private void OnClickRefreshBuffBtn()
		{
		}

		// Token: 0x06007669 RID: 30313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007669")]
		[Address(RVA = "0x2161AF4", Offset = "0x2161AF4", VA = "0x7BBC961AF4")]
		private void RefreshChooseBuffState()
		{
		}

		// Token: 0x0600766A RID: 30314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600766A")]
		[Address(RVA = "0x2162190", Offset = "0x2162190", VA = "0x7BBC962190")]
		public UIGachaEnergyContent()
		{
		}

		// Token: 0x04008D3D RID: 36157
		[Token(Token = "0x4008D3D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string GACHA_ENERGY_BUFF_STATE;

		// Token: 0x04008D3E RID: 36158
		[Token(Token = "0x4008D3E")]
		[FieldOffset(Offset = "0x78")]
		private UIGachaEnergyContentView m_View;

		// Token: 0x04008D3F RID: 36159
		[Token(Token = "0x4008D3F")]
		[FieldOffset(Offset = "0x80")]
		private UIModelGacha m_ModelGacha;
	}
}
