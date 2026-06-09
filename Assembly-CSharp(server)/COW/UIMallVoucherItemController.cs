using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001BF7 RID: 7159
	[Token(Token = "0x2001BF7")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB464", Offset = "0x10FB464")]
	public class UIMallVoucherItemController : UIVoucherItemController
	{
		// Token: 0x06009B99 RID: 39833 RVA: 0x00028E00 File Offset: 0x00027000
		[Token(Token = "0x6009B99")]
		[Address(RVA = "0x1DF36A8", Offset = "0x1DF36A8", VA = "0x7BBC5F36A8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009B9A RID: 39834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B9A")]
		[Address(RVA = "0x1DF36F8", Offset = "0x1DF36F8", VA = "0x7BBC5F36F8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009B9B RID: 39835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B9B")]
		[Address(RVA = "0x1DF37DC", Offset = "0x1DF37DC", VA = "0x7BBC5F37DC", Slot = "34")]
		public override void RefreshView()
		{
		}

		// Token: 0x06009B9C RID: 39836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009B9C")]
		[Address(RVA = "0x1DF3CD0", Offset = "0x1DF3CD0", VA = "0x7BBC5F3CD0")]
		public UIMallVoucherItemController()
		{
		}

		// Token: 0x0400A1D5 RID: 41429
		[Token(Token = "0x400A1D5")]
		[FieldOffset(Offset = "0x98")]
		private UIMallVoucherItemView m_View;
	}
}
