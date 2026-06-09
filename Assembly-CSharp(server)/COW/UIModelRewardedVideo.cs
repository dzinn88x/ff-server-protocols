using System;
using System.Collections.Generic;
using GCommon;
using GCommon.Ads;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001FE8 RID: 8168
	[Token(Token = "0x2001FE8")]
	public class UIModelRewardedVideo : UIBaseModel
	{
		// Token: 0x0600B554 RID: 46420 RVA: 0x00033708 File Offset: 0x00031908
		[Token(Token = "0x600B554")]
		[Address(RVA = "0x22F388C", Offset = "0x22F388C", VA = "0x7BBCAF388C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600B555 RID: 46421 RVA: 0x00033720 File Offset: 0x00031920
		[Token(Token = "0x17000C46")]
		public bool ShouldPreload
		{
			[Token(Token = "0x600B555")]
			[Address(RVA = "0x22F3894", Offset = "0x22F3894", VA = "0x7BBCAF3894")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x0600B556 RID: 46422 RVA: 0x00033738 File Offset: 0x00031938
		[Token(Token = "0x17000C47")]
		public bool ShowRewardedVideo
		{
			[Token(Token = "0x600B556")]
			[Address(RVA = "0x22F389C", Offset = "0x22F389C", VA = "0x7BBCAF389C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B557 RID: 46423 RVA: 0x00033750 File Offset: 0x00031950
		[Token(Token = "0x600B557")]
		[Address(RVA = "0x22F38A4", Offset = "0x22F38A4", VA = "0x7BBCAF38A4")]
		private bool EnableRewardVideo(ESwitch.SwitchFunc func, bool forceEnable = false)
		{
			return default(bool);
		}

		// Token: 0x0600B558 RID: 46424 RVA: 0x00033768 File Offset: 0x00031968
		[Token(Token = "0x600B558")]
		[Address(RVA = "0x22F38AC", Offset = "0x22F38AC", VA = "0x7BBCAF38AC")]
		public bool NeedShowRewardVideoAfterMatch(float curMatchPlayTime)
		{
			return default(bool);
		}

		// Token: 0x0600B559 RID: 46425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B559")]
		[Address(RVA = "0x22F38B4", Offset = "0x22F38B4", VA = "0x7BBCAF38B4")]
		public void AutoClaimPrevAfterMatchRewardVideoAwards()
		{
		}

		// Token: 0x0600B55A RID: 46426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B55A")]
		[Address(RVA = "0x22F38B8", Offset = "0x22F38B8", VA = "0x7BBCAF38B8")]
		public void ClaimPrevAfterMatchRewardVideoAwardsDirectly()
		{
		}

		// Token: 0x0600B55B RID: 46427 RVA: 0x00033780 File Offset: 0x00031980
		[Token(Token = "0x600B55B")]
		[Address(RVA = "0x22F38BC", Offset = "0x22F38BC", VA = "0x7BBCAF38BC")]
		public EActivity.State GetAfterMatchRewardVideoActivityStatus()
		{
			return EActivity.State.State_RECEIVED;
		}

		// Token: 0x0600B55C RID: 46428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B55C")]
		[Address(RVA = "0x22F38C4", Offset = "0x22F38C4", VA = "0x7BBCAF38C4")]
		public ActivityClientInfo GetAfterMatchRewardVideoActivity()
		{
			return null;
		}

		// Token: 0x0600B55D RID: 46429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B55D")]
		[Address(RVA = "0x22F38CC", Offset = "0x22F38CC", VA = "0x7BBCAF38CC")]
		public ClientActivityDesc GetAfterMatchRewardVideoActivityDesc()
		{
			return null;
		}

		// Token: 0x0600B55E RID: 46430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B55E")]
		[Address(RVA = "0x22F38D4", Offset = "0x22F38D4", VA = "0x7BBCAF38D4")]
		public ActivityGroupDesc GetAfterMatchRewardVideoGroupDesc()
		{
			return null;
		}

		// Token: 0x0600B55F RID: 46431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B55F")]
		[Address(RVA = "0x22F38DC", Offset = "0x22F38DC", VA = "0x7BBCAF38DC")]
		public void Initialize()
		{
		}

		// Token: 0x0600B560 RID: 46432 RVA: 0x00033798 File Offset: 0x00031998
		[Token(Token = "0x600B560")]
		[Address(RVA = "0x22F38E0", Offset = "0x22F38E0", VA = "0x7BBCAF38E0")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x0600B561 RID: 46433 RVA: 0x000337B0 File Offset: 0x000319B0
		[Token(Token = "0x17000C48")]
		public UIModelRewardedVideo.LoadStatus StatusOfLoad
		{
			[Token(Token = "0x600B561")]
			[Address(RVA = "0x22F38E8", Offset = "0x22F38E8", VA = "0x7BBCAF38E8")]
			get
			{
				return UIModelRewardedVideo.LoadStatus.Unloaded;
			}
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x0600B562 RID: 46434 RVA: 0x000337C8 File Offset: 0x000319C8
		[Token(Token = "0x17000C49")]
		public UIModelRewardedVideo.PlayStatus StatusOfPlay
		{
			[Token(Token = "0x600B562")]
			[Address(RVA = "0x22F38F0", Offset = "0x22F38F0", VA = "0x7BBCAF38F0")]
			get
			{
				return UIModelRewardedVideo.PlayStatus.None;
			}
		}

		// Token: 0x0600B563 RID: 46435 RVA: 0x000337E0 File Offset: 0x000319E0
		[Token(Token = "0x600B563")]
		[Address(RVA = "0x22F38F8", Offset = "0x22F38F8", VA = "0x7BBCAF38F8")]
		public bool CanCancelLoad()
		{
			return default(bool);
		}

		// Token: 0x0600B564 RID: 46436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B564")]
		[Address(RVA = "0x22F3900", Offset = "0x22F3900", VA = "0x7BBCAF3900")]
		public void CancelLoad()
		{
		}

		// Token: 0x0600B565 RID: 46437 RVA: 0x000337F8 File Offset: 0x000319F8
		[Token(Token = "0x600B565")]
		[Address(RVA = "0x22F3904", Offset = "0x22F3904", VA = "0x7BBCAF3904")]
		public bool CanCancelPlay()
		{
			return default(bool);
		}

		// Token: 0x0600B566 RID: 46438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B566")]
		[Address(RVA = "0x22F390C", Offset = "0x22F390C", VA = "0x7BBCAF390C")]
		public void CancelPlay()
		{
		}

		// Token: 0x0600B567 RID: 46439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B567")]
		[Address(RVA = "0x22F3910", Offset = "0x22F3910", VA = "0x7BBCAF3910")]
		public void Load(EActivity.Event evt)
		{
		}

		// Token: 0x0600B568 RID: 46440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B568")]
		[Address(RVA = "0x22F3914", Offset = "0x22F3914", VA = "0x7BBCAF3914")]
		public void Play(EActivity.Event evt)
		{
		}

		// Token: 0x0600B569 RID: 46441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B569")]
		[Address(RVA = "0x22F3918", Offset = "0x22F3918", VA = "0x7BBCAF3918")]
		private void OnLoadCallback(bool loaded)
		{
		}

		// Token: 0x0600B56A RID: 46442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B56A")]
		[Address(RVA = "0x22F391C", Offset = "0x22F391C", VA = "0x7BBCAF391C")]
		private void OnPlayEvent(BaseRewardedVideoAds.PlayEvent pe)
		{
		}

		// Token: 0x0600B56B RID: 46443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B56B")]
		[Address(RVA = "0x22F3920", Offset = "0x22F3920", VA = "0x7BBCAF3920")]
		public UIModelRewardedVideo()
		{
		}

		// Token: 0x0400B78C RID: 46988
		[Token(Token = "0x400B78C")]
		public const uint PropID_LoadCallback = 2U;

		// Token: 0x0400B78D RID: 46989
		[Token(Token = "0x400B78D")]
		public const uint PropID_PlayCallback = 4U;

		// Token: 0x0400B78E RID: 46990
		[Token(Token = "0x400B78E")]
		public const uint PropID_PlaySuccess = 8U;

		// Token: 0x0400B78F RID: 46991
		[Token(Token = "0x400B78F")]
		[FieldOffset(Offset = "0x18")]
		private EActivity.Event m_EventOnTrigger;

		// Token: 0x0400B790 RID: 46992
		[Token(Token = "0x400B790")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<EActivity.Event, string> AdUnitIDs;

		// Token: 0x0400B791 RID: 46993
		[Token(Token = "0x400B791")]
		private const bool TEST_MODE = false;

		// Token: 0x0400B792 RID: 46994
		[Token(Token = "0x400B792")]
		[FieldOffset(Offset = "0x20")]
		private BaseRewardedVideoAds _handler;

		// Token: 0x0400B793 RID: 46995
		[Token(Token = "0x400B793")]
		[FieldOffset(Offset = "0x28")]
		private UIModelRewardedVideo.PlayResult _PendingResult;

		// Token: 0x0400B794 RID: 46996
		[Token(Token = "0x400B794")]
		[FieldOffset(Offset = "0x30")]
		private float volume;

		// Token: 0x02001FE9 RID: 8169
		[Token(Token = "0x2001FE9")]
		public class PlayResult
		{
			// Token: 0x0600B56D RID: 46445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B56D")]
			[Address(RVA = "0x22F3A88", Offset = "0x22F3A88", VA = "0x7BBCAF3A88")]
			public PlayResult()
			{
			}

			// Token: 0x0400B795 RID: 46997
			[Token(Token = "0x400B795")]
			[FieldOffset(Offset = "0x10")]
			public bool Opened;

			// Token: 0x0400B796 RID: 46998
			[Token(Token = "0x400B796")]
			[FieldOffset(Offset = "0x11")]
			public bool Played;

			// Token: 0x0400B797 RID: 46999
			[Token(Token = "0x400B797")]
			[FieldOffset(Offset = "0x12")]
			public bool Clicked;

			// Token: 0x0400B798 RID: 47000
			[Token(Token = "0x400B798")]
			[FieldOffset(Offset = "0x13")]
			public bool Completed;

			// Token: 0x0400B799 RID: 47001
			[Token(Token = "0x400B799")]
			[FieldOffset(Offset = "0x14")]
			public bool Rewarded;
		}

		// Token: 0x02001FEA RID: 8170
		[Token(Token = "0x2001FEA")]
		public enum LoadStatus
		{
			// Token: 0x0400B79B RID: 47003
			[Token(Token = "0x400B79B")]
			Unloaded,
			// Token: 0x0400B79C RID: 47004
			[Token(Token = "0x400B79C")]
			Loading,
			// Token: 0x0400B79D RID: 47005
			[Token(Token = "0x400B79D")]
			Loaded
		}

		// Token: 0x02001FEB RID: 8171
		[Token(Token = "0x2001FEB")]
		public enum PlayStatus
		{
			// Token: 0x0400B79F RID: 47007
			[Token(Token = "0x400B79F")]
			None,
			// Token: 0x0400B7A0 RID: 47008
			[Token(Token = "0x400B7A0")]
			Ready,
			// Token: 0x0400B7A1 RID: 47009
			[Token(Token = "0x400B7A1")]
			Playing,
			// Token: 0x0400B7A2 RID: 47010
			[Token(Token = "0x400B7A2")]
			Closed
		}
	}
}
