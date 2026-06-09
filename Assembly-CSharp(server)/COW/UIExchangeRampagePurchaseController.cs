using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200163A RID: 5690
	[Token(Token = "0x200163A")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EFEA4", Offset = "0x10EFEA4")]
	public class UIExchangeRampagePurchaseController : UIMallPurchaseBaseController
	{
		// Token: 0x06006688 RID: 26248 RVA: 0x0001D430 File Offset: 0x0001B630
		[Token(Token = "0x6006688")]
		[Address(RVA = "0x22739D4", Offset = "0x22739D4", VA = "0x7BBCA739D4")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006689 RID: 26249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006689")]
		[Address(RVA = "0x2273A24", Offset = "0x2273A24", VA = "0x7BBCA73A24", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x0600668A RID: 26250 RVA: 0x0001D448 File Offset: 0x0001B648
		// (set) Token: 0x0600668B RID: 26251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000906")]
		protected override int ItemCount
		{
			[Token(Token = "0x600668A")]
			[Address(RVA = "0x2273AF4", Offset = "0x2273AF4", VA = "0x7BBCA73AF4", Slot = "43")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600668B")]
			[Address(RVA = "0x2273AFC", Offset = "0x2273AFC", VA = "0x7BBCA73AFC", Slot = "44")]
			set
			{
			}
		}

		// Token: 0x0600668C RID: 26252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600668C")]
		[Address(RVA = "0x2273BCC", Offset = "0x2273BCC", VA = "0x7BBCA73BCC")]
		private void OnExchangeBtnClick()
		{
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600668D")]
		[Address(RVA = "0x2273CAC", Offset = "0x2273CAC", VA = "0x7BBCA73CAC", Slot = "45")]
		public virtual void RefreshData(BigEventStoreCommodityDesc data)
		{
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600668E")]
		[Address(RVA = "0x2273F0C", Offset = "0x2273F0C", VA = "0x7BBCA73F0C")]
		private void SetExchangeIcon(UISprite sprite)
		{
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600668F")]
		[Address(RVA = "0x227400C", Offset = "0x227400C", VA = "0x7BBCA7400C")]
		public UIExchangeRampagePurchaseController()
		{
		}

		// Token: 0x04008442 RID: 33858
		[Token(Token = "0x4008442")]
		[FieldOffset(Offset = "0xD8")]
		private BigEventStoreCommodityDesc m_Data;
	}
}
