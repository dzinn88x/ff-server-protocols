using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x020013AF RID: 5039
	[Token(Token = "0x20013AF")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EBAF0", Offset = "0x10EBAF0")]
	internal class UISuperCarChangeSkinWndController : UIPopupWindowController
	{
		// Token: 0x060051F9 RID: 20985 RVA: 0x00018AF8 File Offset: 0x00016CF8
		[Token(Token = "0x60051F9")]
		[Address(RVA = "0x213BC9C", Offset = "0x213BC9C", VA = "0x7BBC93BC9C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060051FA RID: 20986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FA")]
		[Address(RVA = "0x213BCEC", Offset = "0x213BCEC", VA = "0x7BBC93BCEC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FB")]
		[Address(RVA = "0x213C494", Offset = "0x213C494", VA = "0x7BBC93C494", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FC")]
		[Address(RVA = "0x213BFA8", Offset = "0x213BFA8", VA = "0x7BBC93BFA8")]
		private void Init()
		{
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FD")]
		[Address(RVA = "0x213C570", Offset = "0x213C570", VA = "0x7BBC93C570")]
		public void RefreshSkinItem()
		{
		}

		// Token: 0x060051FE RID: 20990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FE")]
		[Address(RVA = "0x213CB94", Offset = "0x213CB94", VA = "0x7BBC93CB94")]
		private void OnBtnCarSkinUseBtn()
		{
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FF")]
		[Address(RVA = "0x213CD04", Offset = "0x213CD04", VA = "0x7BBC93CD04")]
		private void OnGetSkinBtnClick()
		{
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005200")]
		[Address(RVA = "0x213C964", Offset = "0x213C964", VA = "0x7BBC93C964")]
		private void OnCarSkinSelect(UISuperCarChangeSkinWndController.CarSkinItem skinItem)
		{
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005201")]
		[Address(RVA = "0x213CE84", Offset = "0x213CE84", VA = "0x7BBC93CE84")]
		private void ProcessAnimEvt(params object[] data)
		{
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005202")]
		[Address(RVA = "0x213CE88", Offset = "0x213CE88", VA = "0x7BBC93CE88")]
		private void ClickMask()
		{
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005203")]
		[Address(RVA = "0x213CF34", Offset = "0x213CF34", VA = "0x7BBC93CF34")]
		public UISuperCarChangeSkinWndController()
		{
		}

		// Token: 0x04007822 RID: 30754
		[Token(Token = "0x4007822")]
		[FieldOffset(Offset = "0x98")]
		private UISuperCarChangeSkinWndView m_View;

		// Token: 0x04007823 RID: 30755
		[Token(Token = "0x4007823")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelSuperCar m_ModelSuperCar;

		// Token: 0x04007824 RID: 30756
		[Token(Token = "0x4007824")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelInventory m_ModelInventory;

		// Token: 0x04007825 RID: 30757
		[Token(Token = "0x4007825")]
		[FieldOffset(Offset = "0xB0")]
		private List<UISuperCarChangeSkinWndController.CarSkinItem> m_CarSkinItemList;

		// Token: 0x04007826 RID: 30758
		[Token(Token = "0x4007826")]
		[FieldOffset(Offset = "0xB8")]
		private List<SupercarSpeedDesc> m_SuperCarSpeedDesc;

		// Token: 0x04007827 RID: 30759
		[Token(Token = "0x4007827")]
		[FieldOffset(Offset = "0xC0")]
		private int m_SelectedID;

		// Token: 0x020013B0 RID: 5040
		[Token(Token = "0x20013B0")]
		public class CarSkinItem : UIInnerView
		{
			// Token: 0x06005204 RID: 20996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005204")]
			[Address(RVA = "0x213CFD4", Offset = "0x213CFD4", VA = "0x7BBC93CFD4", Slot = "4")]
			public override void BindVars(GameObject ui)
			{
			}

			// Token: 0x06005205 RID: 20997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005205")]
			[Address(RVA = "0x213C568", Offset = "0x213C568", VA = "0x7BBC93C568")]
			public CarSkinItem()
			{
			}

			// Token: 0x04007828 RID: 30760
			[Token(Token = "0x4007828")]
			[FieldOffset(Offset = "0x28")]
			public UILabel UseLabel;

			// Token: 0x04007829 RID: 30761
			[Token(Token = "0x4007829")]
			[FieldOffset(Offset = "0x30")]
			public UISprite LockSprite;

			// Token: 0x0400782A RID: 30762
			[Token(Token = "0x400782A")]
			[FieldOffset(Offset = "0x38")]
			public UIToggleButton CarSkinToggleBtn;

			// Token: 0x0400782B RID: 30763
			[Token(Token = "0x400782B")]
			[FieldOffset(Offset = "0x40")]
			public UISprite BgSprite;

			// Token: 0x0400782C RID: 30764
			[Token(Token = "0x400782C")]
			[FieldOffset(Offset = "0x48")]
			public bool Selected;

			// Token: 0x0400782D RID: 30765
			[Token(Token = "0x400782D")]
			[FieldOffset(Offset = "0x4C")]
			public int id;
		}

		// Token: 0x020013B1 RID: 5041
		[Token(Token = "0x20013B1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EBB28", Offset = "0x10EBB28")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06005206 RID: 20998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005206")]
			[Address(RVA = "0x213C560", Offset = "0x213C560", VA = "0x7BBC93C560")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06005207 RID: 20999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005207")]
			[Address(RVA = "0x213CFA4", Offset = "0x213CFA4", VA = "0x7BBC93CFA4")]
			internal void <Init>b__0()
			{
			}

			// Token: 0x0400782E RID: 30766
			[Token(Token = "0x400782E")]
			[FieldOffset(Offset = "0x10")]
			public UISuperCarChangeSkinWndController <>4__this;

			// Token: 0x0400782F RID: 30767
			[Token(Token = "0x400782F")]
			[FieldOffset(Offset = "0x18")]
			public UISuperCarChangeSkinWndController.CarSkinItem skinItem;

			// Token: 0x04007830 RID: 30768
			[Token(Token = "0x4007830")]
			[FieldOffset(Offset = "0x20")]
			public EventDelegate.Callback <>9__0;
		}
	}
}
