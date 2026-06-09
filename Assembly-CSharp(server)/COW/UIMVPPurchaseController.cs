using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200139F RID: 5023
	[Token(Token = "0x200139F")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EB950", Offset = "0x10EB950")]
	public class UIMVPPurchaseController : UIMallPurchaseBaseController
	{
		// Token: 0x0600515F RID: 20831 RVA: 0x00018918 File Offset: 0x00016B18
		[Token(Token = "0x600515F")]
		[Address(RVA = "0x1CCD2C4", Offset = "0x1CCD2C4", VA = "0x7BBC4CD2C4")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005160 RID: 20832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005160")]
		[Address(RVA = "0x1CCD314", Offset = "0x1CCD314", VA = "0x7BBC4CD314", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06005161 RID: 20833 RVA: 0x00018930 File Offset: 0x00016B30
		// (set) Token: 0x06005162 RID: 20834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700086B")]
		protected override int ItemCount
		{
			[Token(Token = "0x6005161")]
			[Address(RVA = "0x1CCD3E4", Offset = "0x1CCD3E4", VA = "0x7BBC4CD3E4", Slot = "43")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005162")]
			[Address(RVA = "0x1CCD3EC", Offset = "0x1CCD3EC", VA = "0x7BBC4CD3EC", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005163")]
		[Address(RVA = "0x1CCD4BC", Offset = "0x1CCD4BC", VA = "0x7BBC4CD4BC")]
		private void OnExchangeBtnClick()
		{
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005164")]
		[Address(RVA = "0x1CCD59C", Offset = "0x1CCD59C", VA = "0x7BBC4CD59C", Slot = "45")]
		public virtual void RefreshData(BigEventStoreCommodityDesc data)
		{
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005165")]
		[Address(RVA = "0x1CCD7FC", Offset = "0x1CCD7FC", VA = "0x7BBC4CD7FC")]
		private void SetExchangeIcon(UISprite sprite)
		{
		}

		// Token: 0x06005166 RID: 20838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005166")]
		[Address(RVA = "0x1CCD8FC", Offset = "0x1CCD8FC", VA = "0x7BBC4CD8FC")]
		public UIMVPPurchaseController()
		{
		}

		// Token: 0x040077C0 RID: 30656
		[Token(Token = "0x40077C0")]
		[FieldOffset(Offset = "0xD8")]
		private BigEventStoreCommodityDesc m_Data;
	}
}
