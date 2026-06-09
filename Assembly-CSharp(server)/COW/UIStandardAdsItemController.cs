using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200166C RID: 5740
	[Token(Token = "0x200166C")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F00C4", Offset = "0x10F00C4")]
	internal class UIStandardAdsItemController : UIBaseController
	{
		// Token: 0x060067DD RID: 26589 RVA: 0x0001D868 File Offset: 0x0001BA68
		[Token(Token = "0x60067DD")]
		[Address(RVA = "0x163C290", Offset = "0x163C290", VA = "0x7BBBE3C290")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060067DE RID: 26590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067DE")]
		[Address(RVA = "0x163C2E0", Offset = "0x163C2E0", VA = "0x7BBBE3C2E0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060067DF RID: 26591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067DF")]
		[Address(RVA = "0x163BC1C", Offset = "0x163BC1C", VA = "0x7BBBE3BC1C")]
		public void RefreshUIData(UIModelLobbyAds.AdInfo info)
		{
		}

		// Token: 0x060067E0 RID: 26592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067E0")]
		[Address(RVA = "0x163C384", Offset = "0x163C384", VA = "0x7BBBE3C384")]
		public void SetTextureSize(float width, float height)
		{
		}

		// Token: 0x060067E1 RID: 26593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60067E1")]
		[Address(RVA = "0x163C498", Offset = "0x163C498", VA = "0x7BBBE3C498")]
		public UIStandardAdsItemController()
		{
		}

		// Token: 0x040084FF RID: 34047
		[Token(Token = "0x40084FF")]
		[FieldOffset(Offset = "0x58")]
		private UIStandardAdsItemView m_View;

		// Token: 0x04008500 RID: 34048
		[Token(Token = "0x4008500")]
		[FieldOffset(Offset = "0x60")]
		public int AdIndex;
	}
}
