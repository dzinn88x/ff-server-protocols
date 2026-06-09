using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001364 RID: 4964
	[Token(Token = "0x2001364")]
	public class UIFFWSPurchaseController : UIMallPurchaseBaseController
	{
		// Token: 0x06004F4E RID: 20302 RVA: 0x00018288 File Offset: 0x00016488
		[Token(Token = "0x6004F4E")]
		[Address(RVA = "0x2284834", Offset = "0x2284834", VA = "0x7BBCA84834")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06004F4F RID: 20303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F4F")]
		[Address(RVA = "0x2284884", Offset = "0x2284884", VA = "0x7BBCA84884", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06004F50 RID: 20304 RVA: 0x000182A0 File Offset: 0x000164A0
		// (set) Token: 0x06004F51 RID: 20305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000868")]
		protected override int ItemCount
		{
			[Token(Token = "0x6004F50")]
			[Address(RVA = "0x2284954", Offset = "0x2284954", VA = "0x7BBCA84954", Slot = "43")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004F51")]
			[Address(RVA = "0x228495C", Offset = "0x228495C", VA = "0x7BBCA8495C", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x06004F52 RID: 20306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F52")]
		[Address(RVA = "0x2284A2C", Offset = "0x2284A2C", VA = "0x7BBCA84A2C")]
		private void OnExchangeBtnClick()
		{
		}

		// Token: 0x06004F53 RID: 20307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F53")]
		[Address(RVA = "0x2284B0C", Offset = "0x2284B0C", VA = "0x7BBCA84B0C", Slot = "45")]
		public virtual void RefreshData(BigEventStoreCommodityDesc data)
		{
		}

		// Token: 0x06004F54 RID: 20308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F54")]
		[Address(RVA = "0x2284D8C", Offset = "0x2284D8C", VA = "0x7BBCA84D8C")]
		private void SetExchangeIcon(UISprite sprite)
		{
		}

		// Token: 0x06004F55 RID: 20309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F55")]
		[Address(RVA = "0x2284E8C", Offset = "0x2284E8C", VA = "0x7BBCA84E8C")]
		public UIFFWSPurchaseController()
		{
		}

		// Token: 0x04007623 RID: 30243
		[Token(Token = "0x4007623")]
		[FieldOffset(Offset = "0xD8")]
		private BigEventStoreCommodityDesc m_Data;
	}
}
