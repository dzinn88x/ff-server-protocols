using System;
using Il2CppDummyDll;

namespace GCommon.Ads
{
	// Token: 0x02001072 RID: 4210
	[Token(Token = "0x2001072")]
	public class BaseRewardedVideoAds
	{
		// Token: 0x06004053 RID: 16467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004053")]
		[Address(RVA = "0x25D76A0", Offset = "0x25D76A0", VA = "0x7BBCDD76A0")]
		protected BaseRewardedVideoAds()
		{
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06004054 RID: 16468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700075D")]
		public static BaseRewardedVideoAds I
		{
			[Token(Token = "0x6004054")]
			[Address(RVA = "0x25D7320", Offset = "0x25D7320", VA = "0x7BBCDD7320")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004055")]
		[Address(RVA = "0x25D76A8", Offset = "0x25D76A8", VA = "0x7BBCDD76A8", Slot = "4")]
		public virtual void Init(bool test_mode)
		{
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x00013D70 File Offset: 0x00011F70
		[Token(Token = "0x6004056")]
		[Address(RVA = "0x25D76AC", Offset = "0x25D76AC", VA = "0x7BBCDD76AC", Slot = "5")]
		public virtual bool IsInited()
		{
			return default(bool);
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06004057 RID: 16471 RVA: 0x00013D88 File Offset: 0x00011F88
		// (set) Token: 0x06004058 RID: 16472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075E")]
		public BaseRewardedVideoAds.LoadStatus StatusOfLoad
		{
			[Token(Token = "0x6004057")]
			[Address(RVA = "0x25D76B4", Offset = "0x25D76B4", VA = "0x7BBCDD76B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C27C", Offset = "0x113C27C")]
			get
			{
				return BaseRewardedVideoAds.LoadStatus.Unloaded;
			}
			[Token(Token = "0x6004058")]
			[Address(RVA = "0x25D76BC", Offset = "0x25D76BC", VA = "0x7BBCDD76BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C28C", Offset = "0x113C28C")]
			protected set
			{
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06004059 RID: 16473 RVA: 0x00013DA0 File Offset: 0x00011FA0
		// (set) Token: 0x0600405A RID: 16474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700075F")]
		public BaseRewardedVideoAds.PlayStatus StatusOfPlay
		{
			[Token(Token = "0x6004059")]
			[Address(RVA = "0x25D76C4", Offset = "0x25D76C4", VA = "0x7BBCDD76C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C29C", Offset = "0x113C29C")]
			get
			{
				return BaseRewardedVideoAds.PlayStatus.None;
			}
			[Token(Token = "0x600405A")]
			[Address(RVA = "0x25D76CC", Offset = "0x25D76CC", VA = "0x7BBCDD76CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C2AC", Offset = "0x113C2AC")]
			protected set
			{
			}
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405B")]
		[Address(RVA = "0x25D76D4", Offset = "0x25D76D4", VA = "0x7BBCDD76D4", Slot = "6")]
		public virtual void Load(Action<bool> callback, string ad_unit_id)
		{
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x00013DB8 File Offset: 0x00011FB8
		[Token(Token = "0x600405C")]
		[Address(RVA = "0x25D7754", Offset = "0x25D7754", VA = "0x7BBCDD7754", Slot = "7")]
		public virtual bool CanCancelLoad()
		{
			return default(bool);
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405D")]
		[Address(RVA = "0x25D775C", Offset = "0x25D775C", VA = "0x7BBCDD775C", Slot = "8")]
		public virtual void CancelLoad()
		{
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x00013DD0 File Offset: 0x00011FD0
		[Token(Token = "0x600405E")]
		[Address(RVA = "0x25D7760", Offset = "0x25D7760", VA = "0x7BBCDD7760", Slot = "9")]
		public virtual bool CanCancelPlay()
		{
			return default(bool);
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600405F")]
		[Address(RVA = "0x25D7768", Offset = "0x25D7768", VA = "0x7BBCDD7768", Slot = "10")]
		public virtual void CancelPlay()
		{
		}

		// Token: 0x06004060 RID: 16480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004060")]
		[Address(RVA = "0x25D776C", Offset = "0x25D776C", VA = "0x7BBCDD776C", Slot = "11")]
		public virtual void Play(Action<BaseRewardedVideoAds.PlayEvent> callback)
		{
		}

		// Token: 0x04004FF3 RID: 20467
		[Token(Token = "0x4004FF3")]
		[FieldOffset(Offset = "0x0")]
		private static BaseRewardedVideoAds _I;

		// Token: 0x04004FF4 RID: 20468
		[Token(Token = "0x4004FF4")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EB9C", Offset = "0x112EB9C")]
		private BaseRewardedVideoAds.LoadStatus <StatusOfLoad>k__BackingField;

		// Token: 0x04004FF5 RID: 20469
		[Token(Token = "0x4004FF5")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EBAC", Offset = "0x112EBAC")]
		private BaseRewardedVideoAds.PlayStatus <StatusOfPlay>k__BackingField;

		// Token: 0x02001073 RID: 4211
		[Token(Token = "0x2001073")]
		public enum LoadStatus
		{
			// Token: 0x04004FF7 RID: 20471
			[Token(Token = "0x4004FF7")]
			Unloaded,
			// Token: 0x04004FF8 RID: 20472
			[Token(Token = "0x4004FF8")]
			Loading,
			// Token: 0x04004FF9 RID: 20473
			[Token(Token = "0x4004FF9")]
			Loaded
		}

		// Token: 0x02001074 RID: 4212
		[Token(Token = "0x2001074")]
		public enum PlayStatus
		{
			// Token: 0x04004FFB RID: 20475
			[Token(Token = "0x4004FFB")]
			None,
			// Token: 0x04004FFC RID: 20476
			[Token(Token = "0x4004FFC")]
			Ready,
			// Token: 0x04004FFD RID: 20477
			[Token(Token = "0x4004FFD")]
			Opening,
			// Token: 0x04004FFE RID: 20478
			[Token(Token = "0x4004FFE")]
			Opened,
			// Token: 0x04004FFF RID: 20479
			[Token(Token = "0x4004FFF")]
			Showing,
			// Token: 0x04005000 RID: 20480
			[Token(Token = "0x4005000")]
			Closed
		}

		// Token: 0x02001075 RID: 4213
		[Token(Token = "0x2001075")]
		public enum PlayEvent
		{
			// Token: 0x04005002 RID: 20482
			[Token(Token = "0x4005002")]
			None,
			// Token: 0x04005003 RID: 20483
			[Token(Token = "0x4005003")]
			Open,
			// Token: 0x04005004 RID: 20484
			[Token(Token = "0x4005004")]
			Play,
			// Token: 0x04005005 RID: 20485
			[Token(Token = "0x4005005")]
			Click,
			// Token: 0x04005006 RID: 20486
			[Token(Token = "0x4005006")]
			Complete,
			// Token: 0x04005007 RID: 20487
			[Token(Token = "0x4005007")]
			Reward,
			// Token: 0x04005008 RID: 20488
			[Token(Token = "0x4005008")]
			Close
		}
	}
}
