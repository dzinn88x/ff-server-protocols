using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x020018E3 RID: 6371
	[Token(Token = "0x20018E3")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F5154", Offset = "0x10F5154")]
	internal class UIHudInGameShopController : UIHudInGameShopBaseController
	{
		// Token: 0x06007F3C RID: 32572 RVA: 0x00022BF0 File Offset: 0x00020DF0
		[Token(Token = "0x6007F3C")]
		[Address(RVA = "0x1988030", Offset = "0x1988030", VA = "0x7BBC188030")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007F3D RID: 32573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F3D")]
		[Address(RVA = "0x1988080", Offset = "0x1988080", VA = "0x7BBC188080", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007F3E RID: 32574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F3E")]
		[Address(RVA = "0x19883C4", Offset = "0x19883C4", VA = "0x7BBC1883C4", Slot = "28")]
		protected override void OnInitSpecialUIElement()
		{
		}

		// Token: 0x06007F3F RID: 32575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F3F")]
		[Address(RVA = "0x198840C", Offset = "0x198840C", VA = "0x7BBC18840C", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06007F40 RID: 32576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F40")]
		[Address(RVA = "0x1988680", Offset = "0x1988680", VA = "0x7BBC188680")]
		private void OnShowHud(params object[] data)
		{
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F41")]
		[Address(RVA = "0x198872C", Offset = "0x198872C", VA = "0x7BBC18872C", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F42")]
		[Address(RVA = "0x1988838", Offset = "0x1988838", VA = "0x7BBC188838")]
		private void InitShopItems()
		{
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x00022C08 File Offset: 0x00020E08
		[Token(Token = "0x6007F43")]
		[Address(RVA = "0x1988FA0", Offset = "0x1988FA0", VA = "0x7BBC188FA0")]
		private JODQotb PrecheckForBuy(oOu}}D^ itemInfo)
		{
			return (JODQotb)0U;
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F44")]
		[Address(RVA = "0x1988DB8", Offset = "0x1988DB8", VA = "0x7BBC188DB8")]
		private void GetOwnerInfo(ref int tokenCount, ref int curBagCapacity, ref int maxBagCapacity)
		{
		}

		// Token: 0x06007F45 RID: 32581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F45")]
		[Address(RVA = "0x1989030", Offset = "0x1989030", VA = "0x7BBC189030", Slot = "30")]
		protected override void OnPurchaseBtnClick()
		{
		}

		// Token: 0x06007F46 RID: 32582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F46")]
		[Address(RVA = "0x1989318", Offset = "0x1989318", VA = "0x7BBC189318")]
		private void ShowBuyResult(JODQotb buyResult)
		{
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F47")]
		[Address(RVA = "0x19896E0", Offset = "0x19896E0", VA = "0x7BBC1896E0", Slot = "32")]
		protected override void OnCloseBtnClick()
		{
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F48")]
		[Address(RVA = "0x19896F0", Offset = "0x19896F0", VA = "0x7BBC1896F0")]
		private void OnCoinBtnClick()
		{
		}

		// Token: 0x06007F49 RID: 32585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F49")]
		[Address(RVA = "0x1989AB4", Offset = "0x1989AB4", VA = "0x7BBC189AB4")]
		private void OnCapacityBtnClick()
		{
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F4A")]
		[Address(RVA = "0x1988788", Offset = "0x1988788", VA = "0x7BBC188788")]
		private void ClearSelected()
		{
		}

		// Token: 0x06007F4B RID: 32587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F4B")]
		[Address(RVA = "0x1989E78", Offset = "0x1989E78", VA = "0x7BBC189E78", Slot = "29")]
		protected override void OnItemSelected(params object[] data)
		{
		}

		// Token: 0x06007F4C RID: 32588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F4C")]
		[Address(RVA = "0x1989F64", Offset = "0x1989F64", VA = "0x7BBC189F64")]
		private void OnLocalPlayerBeHurt(params object[] data)
		{
		}

		// Token: 0x06007F4D RID: 32589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F4D")]
		[Address(RVA = "0x198A018", Offset = "0x198A018", VA = "0x7BBC18A018")]
		private void OnLocalPlayerGetOnVehicle(params object[] data)
		{
		}

		// Token: 0x06007F4E RID: 32590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F4E")]
		[Address(RVA = "0x198A028", Offset = "0x198A028", VA = "0x7BBC18A028")]
		private void OnBuyResultSync(params object[] data)
		{
		}

		// Token: 0x06007F4F RID: 32591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F4F")]
		[Address(RVA = "0x198A0B4", Offset = "0x198A0B4", VA = "0x7BBC18A0B4")]
		private void OnBagCapacityChanged(params object[] data)
		{
		}

		// Token: 0x06007F50 RID: 32592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F50")]
		[Address(RVA = "0x1988EF0", Offset = "0x1988EF0", VA = "0x7BBC188EF0")]
		private void UpdateBagCapacityText()
		{
		}

		// Token: 0x06007F51 RID: 32593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F51")]
		[Address(RVA = "0x198A20C", Offset = "0x198A20C", VA = "0x7BBC18A20C")]
		public UIHudInGameShopController()
		{
		}

		// Token: 0x06007F52 RID: 32594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F52")]
		[Address(RVA = "0x198A284", Offset = "0x198A284", VA = "0x7BBC18A284")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142DE8", Offset = "0x1142DE8")]
		private void <OnCoinBtnClick>b__18_0()
		{
		}

		// Token: 0x06007F53 RID: 32595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F53")]
		[Address(RVA = "0x198A2E0", Offset = "0x198A2E0", VA = "0x7BBC18A2E0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1142DF8", Offset = "0x1142DF8")]
		private void <OnCapacityBtnClick>b__19_0()
		{
		}

		// Token: 0x04009236 RID: 37430
		[Token(Token = "0x4009236")]
		[FieldOffset(Offset = "0x70")]
		private bool m_ShopItemInited;

		// Token: 0x04009237 RID: 37431
		[Token(Token = "0x4009237")]
		[FieldOffset(Offset = "0x78")]
		private oOu}}D^ m_ChoosedItemInfo;

		// Token: 0x04009238 RID: 37432
		[Token(Token = "0x4009238")]
		[FieldOffset(Offset = "0x80")]
		private int m_CurBagCapacity;

		// Token: 0x04009239 RID: 37433
		[Token(Token = "0x4009239")]
		[FieldOffset(Offset = "0x84")]
		private int m_MaxBagCapacity;

		// Token: 0x0400923A RID: 37434
		[Token(Token = "0x400923A")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<uint, UIHudInGameShopCategoryController> m_Categorys;

		// Token: 0x0400923B RID: 37435
		[Token(Token = "0x400923B")]
		[FieldOffset(Offset = "0x90")]
		private uint m_TipDelayCall;

		// Token: 0x020018E4 RID: 6372
		[Token(Token = "0x20018E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F518C", Offset = "0x10F518C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06007F55 RID: 32597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007F55")]
			[Address(RVA = "0x198A3A0", Offset = "0x198A3A0", VA = "0x7BBC18A3A0")]
			public <>c()
			{
			}

			// Token: 0x06007F56 RID: 32598 RVA: 0x00022C20 File Offset: 0x00020E20
			[Token(Token = "0x6007F56")]
			[Address(RVA = "0x198A3A8", Offset = "0x198A3A8", VA = "0x7BBC18A3A8")]
			internal int <InitShopItems>b__12_0(Transform item1, Transform item2)
			{
				return 0;
			}

			// Token: 0x0400923C RID: 37436
			[Token(Token = "0x400923C")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudInGameShopController.<>c <>9;

			// Token: 0x0400923D RID: 37437
			[Token(Token = "0x400923D")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<Transform> <>9__12_0;
		}
	}
}
