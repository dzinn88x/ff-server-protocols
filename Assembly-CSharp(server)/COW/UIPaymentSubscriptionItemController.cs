using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001ADB RID: 6875
	[Token(Token = "0x2001ADB")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8C54", Offset = "0x10F8C54")]
	public class UIPaymentSubscriptionItemController : UIPaymentSubscriptionBaseController, ITipsDelegate
	{
		// Token: 0x06009184 RID: 37252 RVA: 0x00026C10 File Offset: 0x00024E10
		[Token(Token = "0x6009184")]
		[Address(RVA = "0x1F34474", Offset = "0x1F34474", VA = "0x7BBC734474")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009185 RID: 37253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009185")]
		[Address(RVA = "0x1F344C4", Offset = "0x1F344C4", VA = "0x7BBC7344C4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009186 RID: 37254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009186")]
		[Address(RVA = "0x1F34624", Offset = "0x1F34624", VA = "0x7BBC734624", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06009187 RID: 37255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009187")]
		[Address(RVA = "0x1F34758", Offset = "0x1F34758", VA = "0x7BBC734758", Slot = "54")]
		private void OnTipsDataChange(ETipsType type, int num)
		{
		}

		// Token: 0x06009188 RID: 37256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009188")]
		[Address(RVA = "0x1F33F0C", Offset = "0x1F33F0C", VA = "0x7BBC733F0C")]
		public void SetDragScrollView(UIScrollView scrollView)
		{
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06009189 RID: 37257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1F")]
		protected override UILabel PriceLabel
		{
			[Token(Token = "0x6009189")]
			[Address(RVA = "0x1F348D4", Offset = "0x1F348D4", VA = "0x7BBC7348D4", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x0600918A RID: 37258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A20")]
		protected override UILabel PeriodLabel
		{
			[Token(Token = "0x600918A")]
			[Address(RVA = "0x1F34900", Offset = "0x1F34900", VA = "0x7BBC734900", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x0600918B RID: 37259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A21")]
		protected override UITable PricingTable
		{
			[Token(Token = "0x600918B")]
			[Address(RVA = "0x1F3492C", Offset = "0x1F3492C", VA = "0x7BBC73492C", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x0600918C RID: 37260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A22")]
		protected override UILabel SubscribeButtonLabel
		{
			[Token(Token = "0x600918C")]
			[Address(RVA = "0x1F34934", Offset = "0x1F34934", VA = "0x7BBC734934", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x0600918D RID: 37261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A23")]
		protected override UINetworkTextureExt NetworkTexture
		{
			[Token(Token = "0x600918D")]
			[Address(RVA = "0x1F3493C", Offset = "0x1F3493C", VA = "0x7BBC73493C", Slot = "34")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x0600918E RID: 37262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A24")]
		protected override string NetworkTextureUrl
		{
			[Token(Token = "0x600918E")]
			[Address(RVA = "0x1F34968", Offset = "0x1F34968", VA = "0x7BBC734968", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x0600918F RID: 37263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A25")]
		protected override GameObject BonusGameObject
		{
			[Token(Token = "0x600918F")]
			[Address(RVA = "0x1F34994", Offset = "0x1F34994", VA = "0x7BBC734994", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06009190 RID: 37264 RVA: 0x00026C28 File Offset: 0x00024E28
		[Token(Token = "0x17000A26")]
		protected override bool BonusAvailable
		{
			[Token(Token = "0x6009190")]
			[Address(RVA = "0x1F3499C", Offset = "0x1F3499C", VA = "0x7BBC73499C", Slot = "37")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06009191 RID: 37265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A27")]
		protected override UILabel BonusLabel
		{
			[Token(Token = "0x6009191")]
			[Address(RVA = "0x1F349A4", Offset = "0x1F349A4", VA = "0x7BBC7349A4", Slot = "38")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06009192 RID: 37266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A28")]
		protected override UIButton FixOnHoldButton
		{
			[Token(Token = "0x6009192")]
			[Address(RVA = "0x1F349AC", Offset = "0x1F349AC", VA = "0x7BBC7349AC", Slot = "40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06009193 RID: 37267 RVA: 0x00026C40 File Offset: 0x00024E40
		[Token(Token = "0x17000A29")]
		protected override int BonusAmount
		{
			[Token(Token = "0x6009193")]
			[Address(RVA = "0x1F349B4", Offset = "0x1F349B4", VA = "0x7BBC7349B4", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06009194 RID: 37268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009194")]
		[Address(RVA = "0x1F349BC", Offset = "0x1F349BC", VA = "0x7BBC7349BC", Slot = "41")]
		protected override GameObject GameObjectForStatus(bool subscribing)
		{
			return null;
		}

		// Token: 0x06009195 RID: 37269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009195")]
		[Address(RVA = "0x1F34A08", Offset = "0x1F34A08", VA = "0x7BBC734A08", Slot = "42")]
		protected override GameObject GameObjectForGracePeriod(bool inGracePeriod)
		{
			return null;
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009196")]
		[Address(RVA = "0x1F34A10", Offset = "0x1F34A10", VA = "0x7BBC734A10", Slot = "43")]
		protected override GameObject GameObjectForOnHold(bool isOnHold)
		{
			return null;
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009197")]
		[Address(RVA = "0x1F34A18", Offset = "0x1F34A18", VA = "0x7BBC734A18", Slot = "46")]
		protected override void UpdateSubscriptionUI()
		{
		}

		// Token: 0x06009198 RID: 37272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009198")]
		[Address(RVA = "0x1F34768", Offset = "0x1F34768", VA = "0x7BBC734768")]
		private void UpdateRedDot()
		{
		}

		// Token: 0x06009199 RID: 37273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009199")]
		[Address(RVA = "0x1F340F8", Offset = "0x1F340F8", VA = "0x7BBC7340F8")]
		public void SetSelected(bool selected)
		{
		}

		// Token: 0x0600919A RID: 37274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600919A")]
		[Address(RVA = "0x1F34A3C", Offset = "0x1F34A3C", VA = "0x7BBC734A3C")]
		private void OnButtonClick()
		{
		}

		// Token: 0x0600919B RID: 37275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600919B")]
		[Address(RVA = "0x1F34B64", Offset = "0x1F34B64", VA = "0x7BBC734B64")]
		public UIPaymentSubscriptionItemController()
		{
		}

		// Token: 0x04009C94 RID: 40084
		[Token(Token = "0x4009C94")]
		[FieldOffset(Offset = "0x78")]
		private UIPaymentSubscriptionItemView m_View;
	}
}
