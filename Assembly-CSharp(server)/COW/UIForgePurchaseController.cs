using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017C2 RID: 6082
	[Token(Token = "0x20017C2")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2B2C", Offset = "0x10F2B2C")]
	public class UIForgePurchaseController : UIMallPurchaseBaseController
	{
		// Token: 0x060074AF RID: 29871 RVA: 0x00020628 File Offset: 0x0001E828
		[Token(Token = "0x60074AF")]
		[Address(RVA = "0x1DBEC10", Offset = "0x1DBEC10", VA = "0x7BBC5BEC10")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B0")]
		[Address(RVA = "0x1DBEC60", Offset = "0x1DBEC60", VA = "0x7BBC5BEC60", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B1")]
		[Address(RVA = "0x1DBEF08", Offset = "0x1DBEF08", VA = "0x7BBC5BEF08")]
		private void OnExchangeBtnClick()
		{
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B2")]
		[Address(RVA = "0x1DBED90", Offset = "0x1DBED90", VA = "0x7BBC5BED90")]
		private void InitMaterialDict()
		{
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B3")]
		[Address(RVA = "0x1DB8B74", Offset = "0x1DB8B74", VA = "0x7BBC5B8B74")]
		public void RefreshData(ChestSpecialExchangeDesc exchangeDesc)
		{
		}

		// Token: 0x060074B4 RID: 29876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B4")]
		[Address(RVA = "0x1DBEFCC", Offset = "0x1DBEFCC", VA = "0x7BBC5BEFCC")]
		protected void SetExchangeIcon(UISprite sprite, uint itemID)
		{
		}

		// Token: 0x060074B5 RID: 29877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60074B5")]
		[Address(RVA = "0x1DBF0B4", Offset = "0x1DBF0B4", VA = "0x7BBC5BF0B4")]
		public UIForgePurchaseController()
		{
		}

		// Token: 0x04008C6C RID: 35948
		[Token(Token = "0x4008C6C")]
		[FieldOffset(Offset = "0xD8")]
		private ChestSpecialExchangeDesc m_ExchangeDesc;

		// Token: 0x04008C6D RID: 35949
		[Token(Token = "0x4008C6D")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<int, UISprite> m_ExchangeMaterial;

		// Token: 0x04008C6E RID: 35950
		[Token(Token = "0x4008C6E")]
		[FieldOffset(Offset = "0xE8")]
		private Dictionary<int, UILabel> m_ExchangeMaterialCount;
	}
}
