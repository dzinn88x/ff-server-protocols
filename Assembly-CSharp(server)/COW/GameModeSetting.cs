using System;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020011B9 RID: 4537
	[Token(Token = "0x20011B9")]
	internal class GameModeSetting : ICloneable
	{
		// Token: 0x0600468C RID: 18060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600468C")]
		[Address(RVA = "0x187ED9C", Offset = "0x187ED9C", VA = "0x7BBC07ED9C", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468D")]
		[Address(RVA = "0x187EDA4", Offset = "0x187EDA4", VA = "0x7BBC07EDA4")]
		public GameModeSetting()
		{
		}

		// Token: 0x04005CF4 RID: 23796
		[Token(Token = "0x4005CF4")]
		[FieldOffset(Offset = "0x10")]
		public readonly int PlayerMaxHP;

		// Token: 0x04005CF5 RID: 23797
		[Token(Token = "0x4005CF5")]
		[FieldOffset(Offset = "0x14")]
		public readonly int VehicleMaxHP;

		// Token: 0x04005CF6 RID: 23798
		[Token(Token = "0x4005CF6")]
		[FieldOffset(Offset = "0x18")]
		public readonly bool RandomAirLineEndJump;

		// Token: 0x04005CF7 RID: 23799
		[Token(Token = "0x4005CF7")]
		[FieldOffset(Offset = "0x19")]
		public readonly bool EnableInventory;

		// Token: 0x04005CF8 RID: 23800
		[Token(Token = "0x4005CF8")]
		[FieldOffset(Offset = "0x1A")]
		public readonly bool EnableVehicleChangeSeat;

		// Token: 0x04005CF9 RID: 23801
		[Token(Token = "0x4005CF9")]
		[FieldOffset(Offset = "0x1B")]
		public readonly bool EnableVehicleBoost;

		// Token: 0x04005CFA RID: 23802
		[Token(Token = "0x4005CFA")]
		[FieldOffset(Offset = "0x1C")]
		public readonly bool EnableVehicleJump;

		// Token: 0x04005CFB RID: 23803
		[Token(Token = "0x4005CFB")]
		[FieldOffset(Offset = "0x1D")]
		public readonly bool EnableVehicleRepairKit;

		// Token: 0x04005CFC RID: 23804
		[Token(Token = "0x4005CFC")]
		[FieldOffset(Offset = "0x1E")]
		public readonly bool EnableVehicleFire;

		// Token: 0x04005CFD RID: 23805
		[Token(Token = "0x4005CFD")]
		[FieldOffset(Offset = "0x1F")]
		public readonly bool EnableInGameQuit;

		// Token: 0x04005CFE RID: 23806
		[Token(Token = "0x4005CFE")]
		[FieldOffset(Offset = "0x20")]
		public readonly bool EnableReplaceEPWithVehicleHp;

		// Token: 0x04005CFF RID: 23807
		[Token(Token = "0x4005CFF")]
		[FieldOffset(Offset = "0x21")]
		public readonly bool EnableSkySurfing;

		// Token: 0x04005D00 RID: 23808
		[Token(Token = "0x4005D00")]
		[FieldOffset(Offset = "0x22")]
		public readonly bool DriverFreeCamera;

		// Token: 0x04005D01 RID: 23809
		[Token(Token = "0x4005D01")]
		[FieldOffset(Offset = "0x23")]
		public readonly bool EnableStrop;

		// Token: 0x04005D02 RID: 23810
		[Token(Token = "0x4005D02")]
		[FieldOffset(Offset = "0x24")]
		public readonly bool EnableCatapult;

		// Token: 0x04005D03 RID: 23811
		[Token(Token = "0x4005D03")]
		[FieldOffset(Offset = "0x25")]
		public readonly bool EnableOilDrum;

		// Token: 0x04005D04 RID: 23812
		[Token(Token = "0x4005D04")]
		[FieldOffset(Offset = "0x28")]
		public readonly float SkyDivingForceToOpenParachuteHeight;

		// Token: 0x04005D05 RID: 23813
		[Token(Token = "0x4005D05")]
		[FieldOffset(Offset = "0x2C")]
		public readonly bool SkyDivingInVehilceCanFire;

		// Token: 0x04005D06 RID: 23814
		[Token(Token = "0x4005D06")]
		[FieldOffset(Offset = "0x2D")]
		public readonly bool ShowAutoSlidingBtn;

		// Token: 0x04005D07 RID: 23815
		[Token(Token = "0x4005D07")]
		[FieldOffset(Offset = "0x2E")]
		public readonly bool EnableVehicleInvincible;

		// Token: 0x04005D08 RID: 23816
		[Token(Token = "0x4005D08")]
		[FieldOffset(Offset = "0x2F")]
		public readonly bool UnlimitedAmmo;

		// Token: 0x04005D09 RID: 23817
		[Token(Token = "0x4005D09")]
		[FieldOffset(Offset = "0x30")]
		public readonly bool UnlimitBagCapacity;

		// Token: 0x04005D0A RID: 23818
		[Token(Token = "0x4005D0A")]
		[FieldOffset(Offset = "0x31")]
		public readonly bool BanAimAssist;

		// Token: 0x04005D0B RID: 23819
		[Token(Token = "0x4005D0B")]
		[FieldOffset(Offset = "0x32")]
		public readonly bool AutoFireAvailable;

		// Token: 0x04005D0C RID: 23820
		[Token(Token = "0x4005D0C")]
		[FieldOffset(Offset = "0x33")]
		public readonly bool EnableBigHead;

		// Token: 0x04005D0D RID: 23821
		[Token(Token = "0x4005D0D")]
		[FieldOffset(Offset = "0x34")]
		public readonly bool EnableFireColliderScale;

		// Token: 0x04005D0E RID: 23822
		[Token(Token = "0x4005D0E")]
		[FieldOffset(Offset = "0x38")]
		public readonly float FireColliderRadiusScale;

		// Token: 0x04005D0F RID: 23823
		[Token(Token = "0x4005D0F")]
		[FieldOffset(Offset = "0x3C")]
		public readonly float FireColliderHeightScale;

		// Token: 0x04005D10 RID: 23824
		[Token(Token = "0x4005D10")]
		[FieldOffset(Offset = "0x40")]
		public readonly int ScoreToWin;

		// Token: 0x04005D11 RID: 23825
		[Token(Token = "0x4005D11")]
		[FieldOffset(Offset = "0x44")]
		public readonly int ScoreToWinEndTime;

		// Token: 0x04005D12 RID: 23826
		[Token(Token = "0x4005D12")]
		[FieldOffset(Offset = "0x48")]
		public readonly float MatchStartPrepareTime;

		// Token: 0x04005D13 RID: 23827
		[Token(Token = "0x4005D13")]
		[FieldOffset(Offset = "0x4C")]
		public readonly int DoubleScoreStartTime;

		// Token: 0x04005D14 RID: 23828
		[Token(Token = "0x4005D14")]
		[FieldOffset(Offset = "0x50")]
		public readonly int ResultShowEmoteId;

		// Token: 0x04005D15 RID: 23829
		[Token(Token = "0x4005D15")]
		[FieldOffset(Offset = "0x54")]
		public readonly int ResultShowEmoteId_SnowManWin;

		// Token: 0x04005D16 RID: 23830
		[Token(Token = "0x4005D16")]
		[FieldOffset(Offset = "0x58")]
		public readonly int ResultShowEmoteId_SnowManLose;

		// Token: 0x04005D17 RID: 23831
		[Token(Token = "0x4005D17")]
		[FieldOffset(Offset = "0x5C")]
		public readonly bool NeedResultShowData;

		// Token: 0x04005D18 RID: 23832
		[Token(Token = "0x4005D18")]
		[FieldOffset(Offset = "0x5D")]
		public readonly bool BanAvatarSkill;

		// Token: 0x04005D19 RID: 23833
		[Token(Token = "0x4005D19")]
		[FieldOffset(Offset = "0x5E")]
		public readonly bool EnableAssistantTips;

		// Token: 0x04005D1A RID: 23834
		[Token(Token = "0x4005D1A")]
		[FieldOffset(Offset = "0x5F")]
		public readonly bool EnableAssistantTriggerTips;

		// Token: 0x04005D1B RID: 23835
		[Token(Token = "0x4005D1B")]
		[FieldOffset(Offset = "0x60")]
		public readonly bool EnableAssistantMarkItemTips;

		// Token: 0x04005D1C RID: 23836
		[Token(Token = "0x4005D1C")]
		[FieldOffset(Offset = "0x64")]
		public readonly int MaxPumpkinOnHead;

		// Token: 0x04005D1D RID: 23837
		[Token(Token = "0x4005D1D")]
		[FieldOffset(Offset = "0x68")]
		public readonly int GameIntroDelayTime;

		// Token: 0x04005D1E RID: 23838
		[Token(Token = "0x4005D1E")]
		[FieldOffset(Offset = "0x6C")]
		public readonly int GameIntroTime;

		// Token: 0x04005D1F RID: 23839
		[Token(Token = "0x4005D1F")]
		[FieldOffset(Offset = "0x70")]
		public readonly bool SafeZoneIgnoreFirstOne;

		// Token: 0x04005D20 RID: 23840
		[Token(Token = "0x4005D20")]
		[FieldOffset(Offset = "0x74")]
		public readonly float MinimapScale;

		// Token: 0x04005D21 RID: 23841
		[Token(Token = "0x4005D21")]
		[FieldOffset(Offset = "0x78")]
		public readonly bool MinimapEnableDynamicScaling;

		// Token: 0x04005D22 RID: 23842
		[Token(Token = "0x4005D22")]
		[FieldOffset(Offset = "0x79")]
		public readonly bool MinimapEnableFirstScale;

		// Token: 0x04005D23 RID: 23843
		[Token(Token = "0x4005D23")]
		[FieldOffset(Offset = "0x7A")]
		public readonly bool MinimapEnableSafezoneScale;

		// Token: 0x04005D24 RID: 23844
		[Token(Token = "0x4005D24")]
		[FieldOffset(Offset = "0x7B")]
		public readonly bool MinimapEnableVehicleScale;

		// Token: 0x04005D25 RID: 23845
		[Token(Token = "0x4005D25")]
		[FieldOffset(Offset = "0x7C")]
		public readonly float MinimapFirstScaleStableDuration;

		// Token: 0x04005D26 RID: 23846
		[Token(Token = "0x4005D26")]
		[FieldOffset(Offset = "0x80")]
		public readonly float MinimapFirstScaleDuration;

		// Token: 0x04005D27 RID: 23847
		[Token(Token = "0x4005D27")]
		[FieldOffset(Offset = "0x84")]
		public readonly float MinimapSafezoneMaxHalfWidth;

		// Token: 0x04005D28 RID: 23848
		[Token(Token = "0x4005D28")]
		[FieldOffset(Offset = "0x88")]
		public readonly float MinimapSafezoneMinHalfWidth;

		// Token: 0x04005D29 RID: 23849
		[Token(Token = "0x4005D29")]
		[FieldOffset(Offset = "0x8C")]
		public readonly float MinimapVehicleHalfWidth;

		// Token: 0x04005D2A RID: 23850
		[Token(Token = "0x4005D2A")]
		[FieldOffset(Offset = "0x90")]
		public readonly bool EnableTrainingChat;

		// Token: 0x04005D2B RID: 23851
		[Token(Token = "0x4005D2B")]
		[FieldOffset(Offset = "0x94")]
		public readonly float ChatBoxCloseDelay;

		// Token: 0x04005D2C RID: 23852
		[Token(Token = "0x4005D2C")]
		[FieldOffset(Offset = "0x98")]
		public readonly int ChatMsgLengthLimit;

		// Token: 0x04005D2D RID: 23853
		[Token(Token = "0x4005D2D")]
		[FieldOffset(Offset = "0x9C")]
		public readonly float ChatMsgCD;

		// Token: 0x04005D2E RID: 23854
		[Token(Token = "0x4005D2E")]
		[FieldOffset(Offset = "0xA0")]
		public readonly float AddFriendInfoCloseDelay;

		// Token: 0x04005D2F RID: 23855
		[Token(Token = "0x4005D2F")]
		[FieldOffset(Offset = "0xA4")]
		public readonly float InviteDisagreeDelay;

		// Token: 0x04005D30 RID: 23856
		[Token(Token = "0x4005D30")]
		[FieldOffset(Offset = "0xA8")]
		public readonly float HangeUpExpireTime;

		// Token: 0x04005D31 RID: 23857
		[Token(Token = "0x4005D31")]
		[FieldOffset(Offset = "0xAC")]
		public readonly bool KillNotificationTeamColor;

		// Token: 0x04005D32 RID: 23858
		[Token(Token = "0x4005D32")]
		[FieldOffset(Offset = "0xB0")]
		public readonly float PVE_LightTowerPrepareTime;

		// Token: 0x04005D33 RID: 23859
		[Token(Token = "0x4005D33")]
		[FieldOffset(Offset = "0xB4")]
		public readonly bool IsEventZomibieFootballLanucher;

		// Token: 0x04005D34 RID: 23860
		[Token(Token = "0x4005D34")]
		[FieldOffset(Offset = "0xB8")]
		public readonly int SafeZoneIndexToObsoleteExtraLife;

		// Token: 0x04005D35 RID: 23861
		[Token(Token = "0x4005D35")]
		[FieldOffset(Offset = "0xBC")]
		public readonly int ArmsInfoListDelayTime;

		// Token: 0x04005D36 RID: 23862
		[Token(Token = "0x4005D36")]
		[FieldOffset(Offset = "0xC0")]
		public readonly bool IsStackedKillOnlyLocalShow;

		// Token: 0x04005D37 RID: 23863
		[Token(Token = "0x4005D37")]
		[FieldOffset(Offset = "0xC1")]
		public readonly bool IsKillOnlyLocalShow;

		// Token: 0x04005D38 RID: 23864
		[Token(Token = "0x4005D38")]
		[FieldOffset(Offset = "0xC2")]
		public readonly bool IsNeedGoldenAttachmentsShow;

		// Token: 0x04005D39 RID: 23865
		[Token(Token = "0x4005D39")]
		[FieldOffset(Offset = "0xC4")]
		public readonly float MinimapScaleToGameZone;

		// Token: 0x04005D3A RID: 23866
		[Token(Token = "0x4005D3A")]
		[FieldOffset(Offset = "0xC8")]
		public readonly int GameShowLoserAudioRank;

		// Token: 0x04005D3B RID: 23867
		[Token(Token = "0x4005D3B")]
		[FieldOffset(Offset = "0xCC")]
		public readonly float EscortMatchBoss_MaxHP;

		// Token: 0x04005D3C RID: 23868
		[Token(Token = "0x4005D3C")]
		[FieldOffset(Offset = "0xD0")]
		public readonly float EscortMatchBoss_HPReviveRate;

		// Token: 0x04005D3D RID: 23869
		[Token(Token = "0x4005D3D")]
		[FieldOffset(Offset = "0xD4")]
		public readonly float EscortMatchBoss_PlayerAddHPRate;

		// Token: 0x04005D3E RID: 23870
		[Token(Token = "0x4005D3E")]
		[FieldOffset(Offset = "0xD8")]
		public readonly bool NeedIntroCutscene;

		// Token: 0x04005D3F RID: 23871
		[Token(Token = "0x4005D3F")]
		[FieldOffset(Offset = "0xDC")]
		public readonly float ReaperCameraOffset;

		// Token: 0x04005D40 RID: 23872
		[Token(Token = "0x4005D40")]
		[FieldOffset(Offset = "0xE0")]
		public readonly bool HumanTireOpen;

		// Token: 0x04005D41 RID: 23873
		[Token(Token = "0x4005D41")]
		[FieldOffset(Offset = "0xE1")]
		public readonly bool HumanTireTeammateOpen;

		// Token: 0x04005D42 RID: 23874
		[Token(Token = "0x4005D42")]
		[FieldOffset(Offset = "0xE2")]
		public readonly bool HumanTireOppomentOpen;

		// Token: 0x04005D43 RID: 23875
		[Token(Token = "0x4005D43")]
		[FieldOffset(Offset = "0xE3")]
		public readonly bool IsShowEquipNotificationTip;

		// Token: 0x04005D44 RID: 23876
		[Token(Token = "0x4005D44")]
		[FieldOffset(Offset = "0xE4")]
		public readonly float TrainingWaitingPortalTime;

		// Token: 0x04005D45 RID: 23877
		[Token(Token = "0x4005D45")]
		[FieldOffset(Offset = "0xE8")]
		public readonly int weatherNightStart;

		// Token: 0x04005D46 RID: 23878
		[Token(Token = "0x4005D46")]
		[FieldOffset(Offset = "0xEC")]
		public readonly int weatherNightEnd;

		// Token: 0x04005D47 RID: 23879
		[Token(Token = "0x4005D47")]
		[FieldOffset(Offset = "0xF0")]
		public readonly int weatherTwilightStart;

		// Token: 0x04005D48 RID: 23880
		[Token(Token = "0x4005D48")]
		[FieldOffset(Offset = "0xF4")]
		public readonly int weatherTwilightEnd;

		// Token: 0x04005D49 RID: 23881
		[Token(Token = "0x4005D49")]
		[FieldOffset(Offset = "0xF8")]
		public readonly int MeteorDuration;

		// Token: 0x04005D4A RID: 23882
		[Token(Token = "0x4005D4A")]
		[FieldOffset(Offset = "0x100")]
		public readonly string MeteorSpecificTime;

		// Token: 0x04005D4B RID: 23883
		[Token(Token = "0x4005D4B")]
		[FieldOffset(Offset = "0x108")]
		public readonly bool EnableNewMatchResult;

		// Token: 0x04005D4C RID: 23884
		[Token(Token = "0x4005D4C")]
		[FieldOffset(Offset = "0x109")]
		public readonly bool EnableMVPShow;

		// Token: 0x04005D4D RID: 23885
		[Token(Token = "0x4005D4D")]
		[FieldOffset(Offset = "0x10A")]
		public readonly bool EnableMatchResultAvatarForLowMemory;

		// Token: 0x04005D4E RID: 23886
		[Token(Token = "0x4005D4E")]
		[FieldOffset(Offset = "0x10C")]
		public readonly float AimAssistKnockDownParam;

		// Token: 0x04005D4F RID: 23887
		[Token(Token = "0x4005D4F")]
		[FieldOffset(Offset = "0x110")]
		public readonly bool DisableAimAssistReviveParachutingTarget;

		// Token: 0x04005D50 RID: 23888
		[Token(Token = "0x4005D50")]
		[FieldOffset(Offset = "0x111")]
		public readonly bool HumanTireRankModeOpen;

		// Token: 0x04005D51 RID: 23889
		[Token(Token = "0x4005D51")]
		[FieldOffset(Offset = "0x112")]
		public readonly bool PlayerReadyNeedDelay;

		// Token: 0x04005D52 RID: 23890
		[Token(Token = "0x4005D52")]
		[FieldOffset(Offset = "0x113")]
		public readonly bool NeedPreloadPlayerAnimators;

		// Token: 0x04005D53 RID: 23891
		[Token(Token = "0x4005D53")]
		[FieldOffset(Offset = "0x114")]
		public readonly bool ShowBulletHole;

		// Token: 0x04005D54 RID: 23892
		[Token(Token = "0x4005D54")]
		[FieldOffset(Offset = "0x118")]
		public readonly float CSBotAgentTimeoutReconHintDelay;

		// Token: 0x04005D55 RID: 23893
		[Token(Token = "0x4005D55")]
		[FieldOffset(Offset = "0x11C")]
		public readonly float CSBotAgentTimeoutReconHintDuration;

		// Token: 0x04005D56 RID: 23894
		[Token(Token = "0x4005D56")]
		[FieldOffset(Offset = "0x120")]
		public readonly float ADS1v1PrepareCountdownDuration;

		// Token: 0x04005D57 RID: 23895
		[Token(Token = "0x4005D57")]
		[FieldOffset(Offset = "0x124")]
		public readonly float ADS1v1PrepareTransportDuration;

		// Token: 0x04005D58 RID: 23896
		[Token(Token = "0x4005D58")]
		[FieldOffset(Offset = "0x128")]
		public readonly float ADS1v1TransportAnimDuration;

		// Token: 0x04005D59 RID: 23897
		[Token(Token = "0x4005D59")]
		[FieldOffset(Offset = "0x12C")]
		public readonly float ADS1v1EndCountdownDuration;

		// Token: 0x04005D5A RID: 23898
		[Token(Token = "0x4005D5A")]
		[FieldOffset(Offset = "0x130")]
		public readonly float ADSNormalDuration;

		// Token: 0x04005D5B RID: 23899
		[Token(Token = "0x4005D5B")]
		[FieldOffset(Offset = "0x134")]
		public readonly float ADSNormalBonusDuration;

		// Token: 0x04005D5C RID: 23900
		[Token(Token = "0x4005D5C")]
		[FieldOffset(Offset = "0x138")]
		public readonly float ADS1v1Duration;

		// Token: 0x04005D5D RID: 23901
		[Token(Token = "0x4005D5D")]
		[FieldOffset(Offset = "0x13C")]
		public readonly bool CenterSafeZoneOnBigMap;

		// Token: 0x04005D5E RID: 23902
		[Token(Token = "0x4005D5E")]
		[FieldOffset(Offset = "0x13D")]
		public readonly bool CenterSafeZoneOnMiniMap;

		// Token: 0x04005D5F RID: 23903
		[Token(Token = "0x4005D5F")]
		[FieldOffset(Offset = "0x13E")]
		public readonly bool CenterSafeZoneOnSideMap;

		// Token: 0x04005D60 RID: 23904
		[Token(Token = "0x4005D60")]
		[FieldOffset(Offset = "0x13F")]
		public readonly bool OBCenterSafeZoneOnBigMap;

		// Token: 0x04005D61 RID: 23905
		[Token(Token = "0x4005D61")]
		[FieldOffset(Offset = "0x140")]
		public readonly bool OBCenterSafeZoneOnSideMap;

		// Token: 0x04005D62 RID: 23906
		[Token(Token = "0x4005D62")]
		[FieldOffset(Offset = "0x144")]
		public readonly int OBCenterSafeZoneStartStage;

		// Token: 0x04005D63 RID: 23907
		[Token(Token = "0x4005D63")]
		[FieldOffset(Offset = "0x148")]
		public readonly int OBCenterSafeZoneEndStage;

		// Token: 0x04005D64 RID: 23908
		[Token(Token = "0x4005D64")]
		[FieldOffset(Offset = "0x14C")]
		public readonly int OBCenterSafeZoneEndBaseRadius;

		// Token: 0x04005D65 RID: 23909
		[Token(Token = "0x4005D65")]
		[FieldOffset(Offset = "0x150")]
		public readonly bool UseNewDeathCamera;

		// Token: 0x04005D66 RID: 23910
		[Token(Token = "0x4005D66")]
		[FieldOffset(Offset = "0x151")]
		public readonly bool EnableShowMapMarkInHud;

		// Token: 0x04005D67 RID: 23911
		[Token(Token = "0x4005D67")]
		[FieldOffset(Offset = "0x152")]
		public readonly bool UseFullAttachment;

		// Token: 0x04005D68 RID: 23912
		[Token(Token = "0x4005D68")]
		[FieldOffset(Offset = "0x154")]
		public readonly float Pregame_Duration;

		// Token: 0x04005D69 RID: 23913
		[Token(Token = "0x4005D69")]
		[FieldOffset(Offset = "0x158")]
		public readonly float Preset_Duration;

		// Token: 0x04005D6A RID: 23914
		[Token(Token = "0x4005D6A")]
		[FieldOffset(Offset = "0x15C")]
		public readonly int RP_GameObjective;

		// Token: 0x04005D6B RID: 23915
		[Token(Token = "0x4005D6B")]
		[FieldOffset(Offset = "0x160")]
		public readonly int RP_SoulPerPhase;

		// Token: 0x04005D6C RID: 23916
		[Token(Token = "0x4005D6C")]
		[FieldOffset(Offset = "0x164")]
		public readonly int RP_SoulDrainRadius;

		// Token: 0x04005D6D RID: 23917
		[Token(Token = "0x4005D6D")]
		[FieldOffset(Offset = "0x168")]
		public readonly float RP_GameTime;

		// Token: 0x04005D6E RID: 23918
		[Token(Token = "0x4005D6E")]
		[FieldOffset(Offset = "0x16C")]
		public readonly int RP_HP;

		// Token: 0x04005D6F RID: 23919
		[Token(Token = "0x4005D6F")]
		[FieldOffset(Offset = "0x170")]
		public readonly float Control_ControlPointActivatingTime;

		// Token: 0x04005D70 RID: 23920
		[Token(Token = "0x4005D70")]
		[FieldOffset(Offset = "0x174")]
		public readonly float Control_ChangeActivateControlPointInterval;

		// Token: 0x04005D71 RID: 23921
		[Token(Token = "0x4005D71")]
		[FieldOffset(Offset = "0x178")]
		public readonly float Control_StartActivateControlPointInterval;

		// Token: 0x04005D72 RID: 23922
		[Token(Token = "0x4005D72")]
		[FieldOffset(Offset = "0x17C")]
		public readonly float Control_ZoneCloseTips;

		// Token: 0x04005D73 RID: 23923
		[Token(Token = "0x4005D73")]
		[FieldOffset(Offset = "0x180")]
		public readonly float Control_ZoneActivateTips;

		// Token: 0x04005D74 RID: 23924
		[Token(Token = "0x4005D74")]
		[FieldOffset(Offset = "0x184")]
		public readonly float Control_TryingControlDelay;

		// Token: 0x04005D75 RID: 23925
		[Token(Token = "0x4005D75")]
		[FieldOffset(Offset = "0x188")]
		public readonly float Banknote_ScoreChangeDelay;

		// Token: 0x04005D76 RID: 23926
		[Token(Token = "0x4005D76")]
		[FieldOffset(Offset = "0x18C")]
		public readonly float SPPlayLastSafeZoneBGMRadius;

		// Token: 0x04005D77 RID: 23927
		[Token(Token = "0x4005D77")]
		[FieldOffset(Offset = "0x190")]
		public readonly float BountyRepairPoint;

		// Token: 0x04005D78 RID: 23928
		[Token(Token = "0x4005D78")]
		[FieldOffset(Offset = "0x194")]
		public readonly bool EnableQuickChat;

		// Token: 0x04005D79 RID: 23929
		[Token(Token = "0x4005D79")]
		[FieldOffset(Offset = "0x195")]
		public readonly bool BR_CanRevive;
	}
}
