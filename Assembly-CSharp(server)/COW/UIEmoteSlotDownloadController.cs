using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020017AE RID: 6062
	[Token(Token = "0x20017AE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F291C", Offset = "0x10F291C")]
	public class UIEmoteSlotDownloadController : UIBaseController
	{
		// Token: 0x060073E7 RID: 29671 RVA: 0x00020340 File Offset: 0x0001E540
		[Token(Token = "0x60073E7")]
		[Address(RVA = "0x1E78F1C", Offset = "0x1E78F1C", VA = "0x7BBC678F1C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060073E8 RID: 29672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E8")]
		[Address(RVA = "0x1E78F6C", Offset = "0x1E78F6C", VA = "0x7BBC678F6C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060073E9 RID: 29673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073E9")]
		[Address(RVA = "0x1E77E0C", Offset = "0x1E77E0C", VA = "0x7BBC677E0C")]
		public void SetDownloadPosition()
		{
		}

		// Token: 0x060073EA RID: 29674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073EA")]
		[Address(RVA = "0x1E78FD0", Offset = "0x1E78FD0", VA = "0x7BBC678FD0")]
		public UIEmoteSlotDownloadController()
		{
		}

		// Token: 0x04008C11 RID: 35857
		[Token(Token = "0x4008C11")]
		[FieldOffset(Offset = "0x58")]
		private UIHudEmoteDownLoadStateView m_View;

		// Token: 0x04008C12 RID: 35858
		[Token(Token = "0x4008C12")]
		[FieldOffset(Offset = "0x60")]
		private bool m_CollectionABReady;

		// Token: 0x04008C13 RID: 35859
		[Token(Token = "0x4008C13")]
		[FieldOffset(Offset = "0x64")]
		private uint m_ItemIconGrey;
	}
}
