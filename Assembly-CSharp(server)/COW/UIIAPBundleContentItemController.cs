using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020019AD RID: 6573
	[Token(Token = "0x20019AD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F6D54", Offset = "0x10F6D54")]
	public class UIIAPBundleContentItemController : UIStandardItemMiniController
	{
		// Token: 0x060086A7 RID: 34471 RVA: 0x000246F0 File Offset: 0x000228F0
		[Token(Token = "0x60086A7")]
		[Address(RVA = "0x1D232D8", Offset = "0x1D232D8", VA = "0x7BBC5232D8")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060086A8 RID: 34472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086A8")]
		[Address(RVA = "0x1D23328", Offset = "0x1D23328", VA = "0x7BBC523328", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060086A9 RID: 34473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086A9")]
		[Address(RVA = "0x1D23404", Offset = "0x1D23404", VA = "0x7BBC523404")]
		public void SetDragScrollView(UIScrollView scrollView)
		{
		}

		// Token: 0x060086AA RID: 34474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086AA")]
		[Address(RVA = "0x1D23520", Offset = "0x1D23520", VA = "0x7BBC523520", Slot = "28")]
		public override void SetViewData(object data, int data_index)
		{
		}

		// Token: 0x060086AB RID: 34475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086AB")]
		[Address(RVA = "0x1D237D0", Offset = "0x1D237D0", VA = "0x7BBC5237D0", Slot = "29")]
		public override void OnItemBtnClick()
		{
		}

		// Token: 0x060086AC RID: 34476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60086AC")]
		[Address(RVA = "0x1D23B04", Offset = "0x1D23B04", VA = "0x7BBC523B04")]
		public UIIAPBundleContentItemController()
		{
		}

		// Token: 0x040095A1 RID: 38305
		[Token(Token = "0x40095A1")]
		[FieldOffset(Offset = "0x88")]
		private BundleShowData m_BundleData;
	}
}
