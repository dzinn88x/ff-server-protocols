using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001F77 RID: 8055
	[Token(Token = "0x2001F77")]
	public class UIModelMysteryMall : UIBaseModel
	{
		// Token: 0x0600B230 RID: 45616 RVA: 0x00032388 File Offset: 0x00030588
		[Token(Token = "0x600B230")]
		[Address(RVA = "0x241955C", Offset = "0x241955C", VA = "0x7BBCC1955C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B231 RID: 45617 RVA: 0x000323A0 File Offset: 0x000305A0
		[Token(Token = "0x600B231")]
		[Address(RVA = "0x2419564", Offset = "0x2419564", VA = "0x7BBCC19564")]
		public uint GetLastPoolId()
		{
			return 0U;
		}

		// Token: 0x0600B232 RID: 45618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B232")]
		[Address(RVA = "0x24195A0", Offset = "0x24195A0", VA = "0x7BBCC195A0")]
		public void SetLastPoolId(uint newPoolId)
		{
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x0600B233 RID: 45619 RVA: 0x000323B8 File Offset: 0x000305B8
		// (set) Token: 0x0600B234 RID: 45620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BFF")]
		public UIModelMysteryMall.ELuckyDrawFrom LuckyDrawFrom
		{
			[Token(Token = "0x600B233")]
			[Address(RVA = "0x24195A8", Offset = "0x24195A8", VA = "0x7BBCC195A8")]
			get
			{
				return UIModelMysteryMall.ELuckyDrawFrom.DEFAULT;
			}
			[Token(Token = "0x600B234")]
			[Address(RVA = "0x24195B0", Offset = "0x24195B0", VA = "0x7BBCC195B0")]
			set
			{
			}
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B235")]
		[Address(RVA = "0x24195B8", Offset = "0x24195B8", VA = "0x7BBCC195B8", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600B236 RID: 45622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B236")]
		[Address(RVA = "0x2419760", Offset = "0x2419760", VA = "0x7BBCC19760")]
		public UIModelMysteryMall.DiscountShow GetDiscountShowById(uint showId)
		{
			return null;
		}

		// Token: 0x0600B237 RID: 45623 RVA: 0x000323D0 File Offset: 0x000305D0
		[Token(Token = "0x600B237")]
		[Address(RVA = "0x24197E0", Offset = "0x24197E0", VA = "0x7BBCC197E0")]
		public uint GetMyLuckyNum()
		{
			return 0U;
		}

		// Token: 0x0600B238 RID: 45624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B238")]
		[Address(RVA = "0x24197F8", Offset = "0x24197F8", VA = "0x7BBCC197F8")]
		public MysteryShopExpressionDesc GetMysteryMallDesc()
		{
			return null;
		}

		// Token: 0x0600B239 RID: 45625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B239")]
		[Address(RVA = "0x2419800", Offset = "0x2419800", VA = "0x7BBCC19800")]
		public CSGetMysteryShopInfoRes GetMysteryMallInfo()
		{
			return null;
		}

		// Token: 0x0600B23A RID: 45626 RVA: 0x000323E8 File Offset: 0x000305E8
		[Token(Token = "0x600B23A")]
		[Address(RVA = "0x2419808", Offset = "0x2419808", VA = "0x7BBCC19808")]
		public bool IsSupperRewardAndSwitchPool(uint itemId)
		{
			return default(bool);
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B23B")]
		[Address(RVA = "0x24199E0", Offset = "0x24199E0", VA = "0x7BBCC199E0")]
		public void SetMysteryMallDesc(CSGetMysteryExpressionRes res, bool silence = false)
		{
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B23C")]
		[Address(RVA = "0x24198E8", Offset = "0x24198E8", VA = "0x7BBCC198E8")]
		public CSGetMysteryPoolInfoRes GetMysteryPoolInfoById(uint poolId)
		{
			return null;
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B23D")]
		[Address(RVA = "0x2419A18", Offset = "0x2419A18", VA = "0x7BBCC19A18")]
		public ClientMysteryShopSwitchDesc GetMysteryPoolDescById(uint poolId)
		{
			return null;
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x00032400 File Offset: 0x00030600
		[Token(Token = "0x600B23E")]
		[Address(RVA = "0x2419968", Offset = "0x2419968", VA = "0x7BBCC19968")]
		public uint GetAnotherPoolId(uint curPoolId)
		{
			return 0U;
		}

		// Token: 0x0600B23F RID: 45631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B23F")]
		[Address(RVA = "0x2419A98", Offset = "0x2419A98", VA = "0x7BBCC19A98", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B240 RID: 45632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B240")]
		[Address(RVA = "0x2419A9C", Offset = "0x2419A9C", VA = "0x7BBCC19A9C", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B241")]
		[Address(RVA = "0x2419B2C", Offset = "0x2419B2C", VA = "0x7BBCC19B2C")]
		public void SortPoolItemNormalListById(uint poolId)
		{
		}

		// Token: 0x0600B242 RID: 45634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B242")]
		[Address(RVA = "0x2419C4C", Offset = "0x2419C4C", VA = "0x7BBCC19C4C")]
		public void RequestGetMysteryMallInfo(bool silence = false)
		{
		}

		// Token: 0x0600B243 RID: 45635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B243")]
		[Address(RVA = "0x2419E04", Offset = "0x2419E04", VA = "0x7BBCC19E04")]
		public void RequestPurchaseAnotherPool()
		{
		}

		// Token: 0x0600B244 RID: 45636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B244")]
		[Address(RVA = "0x241A02C", Offset = "0x241A02C", VA = "0x7BBCC1A02C")]
		public void RequestPurchaseMysteryItem(MysteryPoolStoreItem storeDesc, uint cnt)
		{
		}

		// Token: 0x0600B245 RID: 45637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B245")]
		[Address(RVA = "0x241A2F0", Offset = "0x241A2F0", VA = "0x7BBCC1A2F0")]
		public void RequestMysteryMallLuckyDraw()
		{
		}

		// Token: 0x0600B246 RID: 45638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B246")]
		[Address(RVA = "0x241A48C", Offset = "0x241A48C", VA = "0x7BBCC1A48C")]
		public void RequestGetMysteryPool(uint poolId)
		{
		}

		// Token: 0x0600B247 RID: 45639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B247")]
		[Address(RVA = "0x241A724", Offset = "0x241A724", VA = "0x7BBCC1A724")]
		public UIModelMysteryMall()
		{
		}

		// Token: 0x0600B248 RID: 45640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B248")]
		[Address(RVA = "0x241A804", Offset = "0x241A804", VA = "0x7BBCC1A804")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146ADC", Offset = "0x1146ADC")]
		private void <RequestGetMysteryMallInfo>b__33_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B249 RID: 45641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B249")]
		[Address(RVA = "0x241A918", Offset = "0x241A918", VA = "0x7BBCC1A918")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146AEC", Offset = "0x1146AEC")]
		private void <RequestPurchaseAnotherPool>b__34_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B24A RID: 45642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B24A")]
		[Address(RVA = "0x241A9B4", Offset = "0x241A9B4", VA = "0x7BBCC1A9B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146AFC", Offset = "0x1146AFC")]
		private void <RequestMysteryMallLuckyDraw>b__36_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B531 RID: 46385
		[Token(Token = "0x400B531")]
		public const int PropID_RefreshMysteryPoolSwitch = 2;

		// Token: 0x0400B532 RID: 46386
		[Token(Token = "0x400B532")]
		public const int PropID_GetMysteryLuckyDraw = 4;

		// Token: 0x0400B533 RID: 46387
		[Token(Token = "0x400B533")]
		public const int PropID_GetMysteryPoolInfo = 8;

		// Token: 0x0400B534 RID: 46388
		[Token(Token = "0x400B534")]
		public const int PropID_RefreshMysteryMall = 16;

		// Token: 0x0400B535 RID: 46389
		[Token(Token = "0x400B535")]
		public const int PropID_RefreshLobbyVFXMystery = 32;

		// Token: 0x0400B536 RID: 46390
		[Token(Token = "0x400B536")]
		[FieldOffset(Offset = "0x18")]
		private uint m_LastPoolId;

		// Token: 0x0400B537 RID: 46391
		[Token(Token = "0x400B537")]
		[FieldOffset(Offset = "0x1C")]
		private UIModelMysteryMall.ELuckyDrawFrom m_LuckyDrawFrom;

		// Token: 0x0400B538 RID: 46392
		[Token(Token = "0x400B538")]
		[FieldOffset(Offset = "0x20")]
		private MysteryShopExpressionDesc m_MysteryMallDesc;

		// Token: 0x0400B539 RID: 46393
		[Token(Token = "0x400B539")]
		[FieldOffset(Offset = "0x28")]
		private CSGetMysteryShopInfoRes m_MysteryMallInfo;

		// Token: 0x0400B53A RID: 46394
		[Token(Token = "0x400B53A")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, CSGetMysteryPoolInfoRes> m_MysteryPoolInfoDict;

		// Token: 0x0400B53B RID: 46395
		[Token(Token = "0x400B53B")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<uint, ClientMysteryShopSwitchDesc> m_MysetryPoolDescDict;

		// Token: 0x0400B53C RID: 46396
		[Token(Token = "0x400B53C")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<uint, UIModelMysteryMall.DiscountShow> m_DiscoutShowDict;

		// Token: 0x02001F78 RID: 8056
		[Token(Token = "0x2001F78")]
		public enum ELuckyDrawFrom
		{
			// Token: 0x0400B53E RID: 46398
			[Token(Token = "0x400B53E")]
			DEFAULT,
			// Token: 0x0400B53F RID: 46399
			[Token(Token = "0x400B53F")]
			ENTRANCE,
			// Token: 0x0400B540 RID: 46400
			[Token(Token = "0x400B540")]
			BUYBUTTON,
			// Token: 0x0400B541 RID: 46401
			[Token(Token = "0x400B541")]
			ADVERTISE
		}

		// Token: 0x02001F79 RID: 8057
		[Token(Token = "0x2001F79")]
		public class DiscountShow
		{
			// Token: 0x0600B24B RID: 45643 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B24B")]
			[Address(RVA = "0x24196CC", Offset = "0x24196CC", VA = "0x7BBCC196CC")]
			public DiscountShow(uint topColor, uint bottomColor, uint tabColor, uint vfxColor)
			{
			}

			// Token: 0x0400B542 RID: 46402
			[Token(Token = "0x400B542")]
			[FieldOffset(Offset = "0x10")]
			public Color topColor;

			// Token: 0x0400B543 RID: 46403
			[Token(Token = "0x400B543")]
			[FieldOffset(Offset = "0x20")]
			public Color bottomColor;

			// Token: 0x0400B544 RID: 46404
			[Token(Token = "0x400B544")]
			[FieldOffset(Offset = "0x30")]
			public Color tabColor;

			// Token: 0x0400B545 RID: 46405
			[Token(Token = "0x400B545")]
			[FieldOffset(Offset = "0x40")]
			public Color vfxColor;
		}

		// Token: 0x02001F7A RID: 8058
		[Token(Token = "0x2001F7A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD2D4", Offset = "0x10FD2D4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B24D RID: 45645 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B24D")]
			[Address(RVA = "0x241AB58", Offset = "0x241AB58", VA = "0x7BBCC1AB58")]
			public <>c()
			{
			}

			// Token: 0x0600B24E RID: 45646 RVA: 0x00032418 File Offset: 0x00030618
			[Token(Token = "0x600B24E")]
			[Address(RVA = "0x241AB60", Offset = "0x241AB60", VA = "0x7BBCC1AB60")]
			internal int <SortPoolItemNormalListById>b__32_0(MysteryPoolStoreItem x, MysteryPoolStoreItem y)
			{
				return 0;
			}

			// Token: 0x0400B546 RID: 46406
			[Token(Token = "0x400B546")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelMysteryMall.<>c <>9;

			// Token: 0x0400B547 RID: 46407
			[Token(Token = "0x400B547")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<MysteryPoolStoreItem> <>9__32_0;
		}

		// Token: 0x02001F7B RID: 8059
		[Token(Token = "0x2001F7B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD2E4", Offset = "0x10FD2E4")]
		private sealed class <>c__DisplayClass35_0
		{
			// Token: 0x0600B24F RID: 45647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B24F")]
			[Address(RVA = "0x241A2E8", Offset = "0x241A2E8", VA = "0x7BBCC1A2E8")]
			public <>c__DisplayClass35_0()
			{
			}

			// Token: 0x0600B250 RID: 45648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B250")]
			[Address(RVA = "0x241AC30", Offset = "0x241AC30", VA = "0x7BBCC1AC30")]
			internal void <RequestPurchaseMysteryItem>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B548 RID: 46408
			[Token(Token = "0x400B548")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMysteryMall <>4__this;

			// Token: 0x0400B549 RID: 46409
			[Token(Token = "0x400B549")]
			[FieldOffset(Offset = "0x18")]
			public MysteryPoolStoreItem storeDesc;

			// Token: 0x0400B54A RID: 46410
			[Token(Token = "0x400B54A")]
			[FieldOffset(Offset = "0x20")]
			public uint cnt;
		}

		// Token: 0x02001F7C RID: 8060
		[Token(Token = "0x2001F7C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD2F4", Offset = "0x10FD2F4")]
		private sealed class <>c__DisplayClass37_0
		{
			// Token: 0x0600B251 RID: 45649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B251")]
			[Address(RVA = "0x241A71C", Offset = "0x241A71C", VA = "0x7BBCC1A71C")]
			public <>c__DisplayClass37_0()
			{
			}

			// Token: 0x0600B252 RID: 45650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B252")]
			[Address(RVA = "0x241B19C", Offset = "0x241B19C", VA = "0x7BBCC1B19C")]
			internal void <RequestGetMysteryPool>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B54B RID: 46411
			[Token(Token = "0x400B54B")]
			[FieldOffset(Offset = "0x10")]
			public UIModelMysteryMall <>4__this;

			// Token: 0x0400B54C RID: 46412
			[Token(Token = "0x400B54C")]
			[FieldOffset(Offset = "0x18")]
			public uint poolId;
		}
	}
}
