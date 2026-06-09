using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001A77 RID: 6775
	[Token(Token = "0x2001A77")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F839C", Offset = "0x10F839C")]
	public class UIMegaFestivalExchangeItemController : UIActivityExchangeItemController
	{
		// Token: 0x06008EB9 RID: 36537 RVA: 0x000260D0 File Offset: 0x000242D0
		[Token(Token = "0x6008EB9")]
		[Address(RVA = "0x1484804", Offset = "0x1484804", VA = "0x7BBBC84804")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008EBA RID: 36538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008EBA")]
		[Address(RVA = "0x1484854", Offset = "0x1484854", VA = "0x7BBBC84854", Slot = "28")]
		protected override object CreateView()
		{
			return null;
		}

		// Token: 0x06008EBB RID: 36539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EBB")]
		[Address(RVA = "0x14849A0", Offset = "0x14849A0", VA = "0x7BBBC849A0")]
		public UIMegaFestivalExchangeItemController()
		{
		}

		// Token: 0x04009A54 RID: 39508
		[Token(Token = "0x4009A54")]
		[FieldOffset(Offset = "0x88")]
		private UIMegaFestivalExchangeItemView m_View;
	}
}
