using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x0200200C RID: 8204
	[Token(Token = "0x200200C")]
	public class UIModelSuperCar : UIBaseModel, IBigEventModel
	{
		// Token: 0x0600B6A1 RID: 46753 RVA: 0x00034110 File Offset: 0x00032310
		[Token(Token = "0x600B6A1")]
		[Address(RVA = "0x2305E10", Offset = "0x2305E10", VA = "0x7BBCB05E10", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B6A2 RID: 46754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6A2")]
		[Address(RVA = "0x2305E18", Offset = "0x2305E18", VA = "0x7BBCB05E18")]
		public SupercarSettingDesc GetSuperCarSetting()
		{
			return null;
		}

		// Token: 0x0600B6A3 RID: 46755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6A3")]
		[Address(RVA = "0x2305E20", Offset = "0x2305E20", VA = "0x7BBCB05E20")]
		public List<SupercarSpeedDesc> GetSuperCarSpeedDesc()
		{
			return null;
		}

		// Token: 0x0600B6A4 RID: 46756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6A4")]
		[Address(RVA = "0x2305E28", Offset = "0x2305E28", VA = "0x7BBCB05E28")]
		public List<SupercarRoundAward> GetSuperCarRoundAwards()
		{
			return null;
		}

		// Token: 0x0600B6A5 RID: 46757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6A5")]
		[Address(RVA = "0x2305E30", Offset = "0x2305E30", VA = "0x7BBCB05E30")]
		public CSGetSupercarInfoRes GetSuperCarInfo()
		{
			return null;
		}

		// Token: 0x0600B6A6 RID: 46758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6A6")]
		[Address(RVA = "0x2305E38", Offset = "0x2305E38", VA = "0x7BBCB05E38")]
		public void InitTokenTipsDesc()
		{
		}

		// Token: 0x0600B6A7 RID: 46759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6A7")]
		[Address(RVA = "0x2305FC0", Offset = "0x2305FC0", VA = "0x7BBCB05FC0")]
		public List<BigEventTokenTipsDesc> GetSugarTokenTipsDescList()
		{
			return null;
		}

		// Token: 0x0600B6A8 RID: 46760 RVA: 0x00034128 File Offset: 0x00032328
		[Token(Token = "0x600B6A8")]
		[Address(RVA = "0x2305FC8", Offset = "0x2305FC8", VA = "0x7BBCB05FC8")]
		public int GetTokenCnt()
		{
			return 0;
		}

		// Token: 0x0600B6A9 RID: 46761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6A9")]
		[Address(RVA = "0x23060A0", Offset = "0x23060A0", VA = "0x7BBCB060A0")]
		public void GetSuperCarPeakDayActivityDesc(out ClientActivityDesc activityDesc, out bool is_Expired)
		{
		}

		// Token: 0x0600B6AA RID: 46762 RVA: 0x00034140 File Offset: 0x00032340
		[Token(Token = "0x600B6AA")]
		[Address(RVA = "0x23061B8", Offset = "0x23061B8", VA = "0x7BBCB061B8")]
		public bool GetSuperCarPeakDayTipsShowOff()
		{
			return default(bool);
		}

		// Token: 0x0600B6AB RID: 46763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6AB")]
		[Address(RVA = "0x2306288", Offset = "0x2306288", VA = "0x7BBCB06288")]
		public void NotifyFriendHelp()
		{
		}

		// Token: 0x0600B6AC RID: 46764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6AC")]
		[Address(RVA = "0x23062EC", Offset = "0x23062EC", VA = "0x7BBCB062EC", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B6AD RID: 46765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6AD")]
		[Address(RVA = "0x23062F4", Offset = "0x23062F4", VA = "0x7BBCB062F4", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B6AE RID: 46766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6AE")]
		[Address(RVA = "0x230640C", Offset = "0x230640C", VA = "0x7BBCB0640C", Slot = "12")]
		protected override void OnSceneChange(params object[] data)
		{
		}

		// Token: 0x0600B6AF RID: 46767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6AF")]
		[Address(RVA = "0x23064C8", Offset = "0x23064C8", VA = "0x7BBCB064C8")]
		public void StartMsgSender()
		{
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B0")]
		[Address(RVA = "0x23065A4", Offset = "0x23065A4", VA = "0x7BBCB065A4")]
		public void CacheGroupInvitationToSend(ulong accountID, FastBigEventMsg msg)
		{
		}

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B1")]
		[Address(RVA = "0x230667C", Offset = "0x230667C", VA = "0x7BBCB0667C")]
		private void SendCachedGroupInvitation()
		{
		}

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B2")]
		[Address(RVA = "0x23067C4", Offset = "0x23067C4", VA = "0x7BBCB067C4")]
		public void RequestSuperCarDesc(uint option = 0U)
		{
		}

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B3")]
		[Address(RVA = "0x23069A0", Offset = "0x23069A0", VA = "0x7BBCB069A0")]
		public void RequestSuperCarInfo(bool needHelp = false, ulong id = 0UL, uint option = 0U)
		{
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B4")]
		[Address(RVA = "0x2306BB8", Offset = "0x2306BB8", VA = "0x7BBCB06BB8")]
		public void RequestSuperCarReward(uint option = 0U)
		{
		}

		// Token: 0x0600B6B5 RID: 46773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B5")]
		[Address(RVA = "0x2306D90", Offset = "0x2306D90", VA = "0x7BBCB06D90")]
		public void RequestChangeSuperCarSkin(uint carID, uint option = 0U)
		{
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B6")]
		[Address(RVA = "0x2306FB8", Offset = "0x2306FB8", VA = "0x7BBCB06FB8")]
		public void RequestSuperCarTokenAcc(uint cnt = 0U, uint option = 0U)
		{
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B7")]
		[Address(RVA = "0x230717C", Offset = "0x230717C", VA = "0x7BBCB0717C")]
		public void RequestSuperCarHelpOther(ulong id, uint option = 0U)
		{
		}

		// Token: 0x0600B6B8 RID: 46776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B8")]
		[Address(RVA = "0x23073D8", Offset = "0x23073D8", VA = "0x7BBCB073D8", Slot = "14")]
		public void OnProcessEventOpenInfo()
		{
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6B9")]
		[Address(RVA = "0x23073DC", Offset = "0x23073DC", VA = "0x7BBCB073DC")]
		public List<ClientActivityDesc> GetSuperCarDailyActivityDesc()
		{
			return null;
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x00034158 File Offset: 0x00032358
		[Token(Token = "0x600B6BA")]
		[Address(RVA = "0x2307484", Offset = "0x2307484", VA = "0x7BBCB07484")]
		public bool GetSuperCarDailyTipsShowOff()
		{
			return default(bool);
		}

		// Token: 0x0600B6BB RID: 46779 RVA: 0x00034170 File Offset: 0x00032370
		[Token(Token = "0x600B6BB")]
		[Address(RVA = "0x2307664", Offset = "0x2307664", VA = "0x7BBCB07664")]
		public float GetCurDriveSum()
		{
			return 0f;
		}

		// Token: 0x0600B6BC RID: 46780 RVA: 0x00034188 File Offset: 0x00032388
		[Token(Token = "0x600B6BC")]
		[Address(RVA = "0x230783C", Offset = "0x230783C", VA = "0x7BBCB0783C")]
		public int GetCurLapNum()
		{
			return 0;
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x000341A0 File Offset: 0x000323A0
		[Token(Token = "0x600B6BD")]
		[Address(RVA = "0x23078A0", Offset = "0x23078A0", VA = "0x7BBCB078A0")]
		public float GetCurDriveRate()
		{
			return 0f;
		}

		// Token: 0x0600B6BE RID: 46782 RVA: 0x000341B8 File Offset: 0x000323B8
		[Token(Token = "0x600B6BE")]
		[Address(RVA = "0x2307758", Offset = "0x2307758", VA = "0x7BBCB07758")]
		public uint GetCurSpeed()
		{
			return 0U;
		}

		// Token: 0x0600B6BF RID: 46783 RVA: 0x000341D0 File Offset: 0x000323D0
		[Token(Token = "0x600B6BF")]
		[Address(RVA = "0x230792C", Offset = "0x230792C", VA = "0x7BBCB0792C")]
		public uint GetHelperSpeed()
		{
			return 0U;
		}

		// Token: 0x0600B6C0 RID: 46784 RVA: 0x000341E8 File Offset: 0x000323E8
		[Token(Token = "0x600B6C0")]
		[Address(RVA = "0x2307A88", Offset = "0x2307A88", VA = "0x7BBCB07A88")]
		public uint GetTokenAccSpeed()
		{
			return 0U;
		}

		// Token: 0x0600B6C1 RID: 46785 RVA: 0x00034200 File Offset: 0x00032400
		[Token(Token = "0x600B6C1")]
		[Address(RVA = "0x2307AB0", Offset = "0x2307AB0", VA = "0x7BBCB07AB0")]
		public float GetCurSpeedFillAmount()
		{
			return 0f;
		}

		// Token: 0x0600B6C2 RID: 46786 RVA: 0x00034218 File Offset: 0x00032418
		[Token(Token = "0x600B6C2")]
		[Address(RVA = "0x2307B3C", Offset = "0x2307B3C", VA = "0x7BBCB07B3C")]
		public float GetAccTokenFillAmount(int tokenCnt)
		{
			return 0f;
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6C3")]
		[Address(RVA = "0x2307BE4", Offset = "0x2307BE4", VA = "0x7BBCB07BE4")]
		public UIModelSuperCar()
		{
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6C4")]
		[Address(RVA = "0x2307D00", Offset = "0x2307D00", VA = "0x7BBCB07D00")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114760C", Offset = "0x114760C")]
		private void <InitTokenTipsDesc>b__25_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B6C5 RID: 46789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6C5")]
		[Address(RVA = "0x2307DE4", Offset = "0x2307DE4", VA = "0x7BBCB07DE4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114761C", Offset = "0x114761C")]
		private void <RequestSuperCarDesc>b__37_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B6C6 RID: 46790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6C6")]
		[Address(RVA = "0x2308228", Offset = "0x2308228", VA = "0x7BBCB08228")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114762C", Offset = "0x114762C")]
		private void <RequestSuperCarReward>b__39_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600B6C7 RID: 46791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6C7")]
		[Address(RVA = "0x2308588", Offset = "0x2308588", VA = "0x7BBCB08588")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114763C", Offset = "0x114763C")]
		private void <RequestSuperCarTokenAcc>b__41_0(HttpErrorCode errorCode, object obj)
		{
		}

		// Token: 0x0600B6C8 RID: 46792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6C8")]
		[Address(RVA = "0x2308734", Offset = "0x2308734", VA = "0x7BBCB08734")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114764C", Offset = "0x114764C")]
		private void <RequestSuperCarHelpOther>b__42_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B8AF RID: 47279
		[Token(Token = "0x400B8AF")]
		public const uint PropID_UpdateSuperCarSetting = 2U;

		// Token: 0x0400B8B0 RID: 47280
		[Token(Token = "0x400B8B0")]
		public const uint PropID_UpdateSuperCarInfo = 4U;

		// Token: 0x0400B8B1 RID: 47281
		[Token(Token = "0x400B8B1")]
		public const uint PropID_GetSuperCarReward = 8U;

		// Token: 0x0400B8B2 RID: 47282
		[Token(Token = "0x400B8B2")]
		public const uint PropID_UpdateHelperInfo = 16U;

		// Token: 0x0400B8B3 RID: 47283
		[Token(Token = "0x400B8B3")]
		public const uint PropID_HeplOtherSuccess = 32U;

		// Token: 0x0400B8B4 RID: 47284
		[Token(Token = "0x400B8B4")]
		public const uint PropID_HeplOtherFailed = 64U;

		// Token: 0x0400B8B5 RID: 47285
		[Token(Token = "0x400B8B5")]
		public const uint PropID_TokenAccFin = 128U;

		// Token: 0x0400B8B6 RID: 47286
		[Token(Token = "0x400B8B6")]
		public const string SuperCarLobbyTip = "SuperCarLobbyTip";

		// Token: 0x0400B8B7 RID: 47287
		[Token(Token = "0x400B8B7")]
		public const string GotoWebTip = "GoWebTipKeySuperCar";

		// Token: 0x0400B8B8 RID: 47288
		[Token(Token = "0x400B8B8")]
		[FieldOffset(Offset = "0x18")]
		private SupercarSettingDesc m_SuperCarSetting;

		// Token: 0x0400B8B9 RID: 47289
		[Token(Token = "0x400B8B9")]
		[FieldOffset(Offset = "0x20")]
		private List<SupercarSpeedDesc> m_SuperCarSpeedDesc;

		// Token: 0x0400B8BA RID: 47290
		[Token(Token = "0x400B8BA")]
		[FieldOffset(Offset = "0x28")]
		private List<SupercarRoundAward> m_SuperCarRoundAward;

		// Token: 0x0400B8BB RID: 47291
		[Token(Token = "0x400B8BB")]
		[FieldOffset(Offset = "0x30")]
		private CSGetSupercarInfoRes m_SuperCarInfo;

		// Token: 0x0400B8BC RID: 47292
		[Token(Token = "0x400B8BC")]
		[FieldOffset(Offset = "0x38")]
		private List<BigEventTokenTipsDesc> m_Token_Sugar;

		// Token: 0x0400B8BD RID: 47293
		[Token(Token = "0x400B8BD")]
		[FieldOffset(Offset = "0x40")]
		private uint m_MsgSender;

		// Token: 0x0400B8BE RID: 47294
		[Token(Token = "0x400B8BE")]
		[FieldOffset(Offset = "0x44")]
		private float SEND_MSG_CD;

		// Token: 0x0400B8BF RID: 47295
		[Token(Token = "0x400B8BF")]
		[FieldOffset(Offset = "0x48")]
		private Queue<UIModelSuperCar.MsgToSend> m_InvitationsToSend;

		// Token: 0x0400B8C0 RID: 47296
		[Token(Token = "0x400B8C0")]
		[FieldOffset(Offset = "0x50")]
		public uint MAX_HELPER_CNT;

		// Token: 0x0200200D RID: 8205
		[Token(Token = "0x200200D")]
		private class MsgToSend
		{
			// Token: 0x0600B6C9 RID: 46793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6C9")]
			[Address(RVA = "0x2306674", Offset = "0x2306674", VA = "0x7BBCB06674")]
			public MsgToSend()
			{
			}

			// Token: 0x0400B8C1 RID: 47297
			[Token(Token = "0x400B8C1")]
			[FieldOffset(Offset = "0x10")]
			public ulong AccountID;

			// Token: 0x0400B8C2 RID: 47298
			[Token(Token = "0x400B8C2")]
			[FieldOffset(Offset = "0x18")]
			public string Msg;
		}

		// Token: 0x0200200E RID: 8206
		[Token(Token = "0x200200E")]
		public enum EFriendCategory
		{
			// Token: 0x0400B8C4 RID: 47300
			[Token(Token = "0x400B8C4")]
			Game,
			// Token: 0x0400B8C5 RID: 47301
			[Token(Token = "0x400B8C5")]
			Platform
		}

		// Token: 0x0200200F RID: 8207
		[Token(Token = "0x200200F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD774", Offset = "0x10FD774")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B6CB RID: 46795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6CB")]
			[Address(RVA = "0x2308814", Offset = "0x2308814", VA = "0x7BBCB08814")]
			public <>c()
			{
			}

			// Token: 0x0600B6CC RID: 46796 RVA: 0x00034230 File Offset: 0x00032430
			[Token(Token = "0x600B6CC")]
			[Address(RVA = "0x230881C", Offset = "0x230881C", VA = "0x7BBCB0881C")]
			internal int <RequestSuperCarDesc>b__37_1(SupercarRoundAward a, SupercarRoundAward b)
			{
				return 0;
			}

			// Token: 0x0600B6CD RID: 46797 RVA: 0x00034248 File Offset: 0x00032448
			[Token(Token = "0x600B6CD")]
			[Address(RVA = "0x2308860", Offset = "0x2308860", VA = "0x7BBCB08860")]
			internal int <RequestSuperCarDesc>b__37_2(SupercarSpeedDesc a, SupercarSpeedDesc b)
			{
				return 0;
			}

			// Token: 0x0600B6CE RID: 46798 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600B6CE")]
			[Address(RVA = "0x23088A4", Offset = "0x23088A4", VA = "0x7BBCB088A4")]
			internal CommonRewardItemInfo <RequestSuperCarReward>b__39_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0400B8C6 RID: 47302
			[Token(Token = "0x400B8C6")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelSuperCar.<>c <>9;

			// Token: 0x0400B8C7 RID: 47303
			[Token(Token = "0x400B8C7")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<SupercarRoundAward> <>9__37_1;

			// Token: 0x0400B8C8 RID: 47304
			[Token(Token = "0x400B8C8")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<SupercarSpeedDesc> <>9__37_2;

			// Token: 0x0400B8C9 RID: 47305
			[Token(Token = "0x400B8C9")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__39_1;
		}

		// Token: 0x02002010 RID: 8208
		[Token(Token = "0x2002010")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD784", Offset = "0x10FD784")]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x0600B6CF RID: 46799 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6CF")]
			[Address(RVA = "0x2306BB0", Offset = "0x2306BB0", VA = "0x7BBCB06BB0")]
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x0600B6D0 RID: 46800 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6D0")]
			[Address(RVA = "0x23088B0", Offset = "0x23088B0", VA = "0x7BBCB088B0")]
			internal void <RequestSuperCarInfo>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B8CA RID: 47306
			[Token(Token = "0x400B8CA")]
			[FieldOffset(Offset = "0x10")]
			public UIModelSuperCar <>4__this;

			// Token: 0x0400B8CB RID: 47307
			[Token(Token = "0x400B8CB")]
			[FieldOffset(Offset = "0x18")]
			public bool needHelp;

			// Token: 0x0400B8CC RID: 47308
			[Token(Token = "0x400B8CC")]
			[FieldOffset(Offset = "0x20")]
			public ulong id;
		}

		// Token: 0x02002011 RID: 8209
		[Token(Token = "0x2002011")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD794", Offset = "0x10FD794")]
		private sealed class <>c__DisplayClass40_0
		{
			// Token: 0x0600B6D1 RID: 46801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6D1")]
			[Address(RVA = "0x2306FB0", Offset = "0x2306FB0", VA = "0x7BBCB06FB0")]
			public <>c__DisplayClass40_0()
			{
			}

			// Token: 0x0600B6D2 RID: 46802 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6D2")]
			[Address(RVA = "0x2308C04", Offset = "0x2308C04", VA = "0x7BBCB08C04")]
			internal void <RequestChangeSuperCarSkin>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400B8CD RID: 47309
			[Token(Token = "0x400B8CD")]
			[FieldOffset(Offset = "0x10")]
			public UIModelSuperCar <>4__this;

			// Token: 0x0400B8CE RID: 47310
			[Token(Token = "0x400B8CE")]
			[FieldOffset(Offset = "0x18")]
			public uint carID;
		}
	}
}
