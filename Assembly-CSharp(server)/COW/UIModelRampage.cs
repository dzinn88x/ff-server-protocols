using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001FC2 RID: 8130
	[Token(Token = "0x2001FC2")]
	public class UIModelRampage : UIBaseModel, IBigEventModel
	{
		// Token: 0x0600B458 RID: 46168 RVA: 0x00033270 File Offset: 0x00031470
		[Token(Token = "0x600B458")]
		[Address(RVA = "0x2393DD4", Offset = "0x2393DD4", VA = "0x7BBCB93DD4", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B459 RID: 46169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B459")]
		[Address(RVA = "0x2393DDC", Offset = "0x2393DDC", VA = "0x7BBCB93DDC", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B45A RID: 46170 RVA: 0x00033288 File Offset: 0x00031488
		[Token(Token = "0x600B45A")]
		[Address(RVA = "0x2393EA8", Offset = "0x2393EA8", VA = "0x7BBCB93EA8")]
		public ELimitedEvent.RampageFaction GetSelfSideType()
		{
			return ELimitedEvent.RampageFaction.RampageFaction_NONE;
		}

		// Token: 0x0600B45B RID: 46171 RVA: 0x000332A0 File Offset: 0x000314A0
		[Token(Token = "0x600B45B")]
		[Address(RVA = "0x2393EC0", Offset = "0x2393EC0", VA = "0x7BBCB93EC0")]
		public ELimitedEvent.RampageFaction GetOpponentSideType()
		{
			return ELimitedEvent.RampageFaction.RampageFaction_NONE;
		}

		// Token: 0x0600B45C RID: 46172 RVA: 0x000332B8 File Offset: 0x000314B8
		[Token(Token = "0x600B45C")]
		[Address(RVA = "0x2393EDC", Offset = "0x2393EDC", VA = "0x7BBCB93EDC")]
		public bool SelfJoinedSide()
		{
			return default(bool);
		}

		// Token: 0x0600B45D RID: 46173 RVA: 0x000332D0 File Offset: 0x000314D0
		[Token(Token = "0x600B45D")]
		[Address(RVA = "0x2393EFC", Offset = "0x2393EFC", VA = "0x7BBCB93EFC")]
		public ELimitedEvent.EventState GetEventState()
		{
			return ELimitedEvent.EventState.EventState_NONE;
		}

		// Token: 0x0600B45E RID: 46174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B45E")]
		[Address(RVA = "0x23940AC", Offset = "0x23940AC", VA = "0x7BBCB940AC")]
		public List<LimitedEventStore> GetStoreList()
		{
			return null;
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x0600B45F RID: 46175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C36")]
		public RampageSettingDesc RampageSettingDesc
		{
			[Token(Token = "0x600B45F")]
			[Address(RVA = "0x23940B4", Offset = "0x23940B4", VA = "0x7BBCB940B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B460 RID: 46176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B460")]
		[Address(RVA = "0x23940BC", Offset = "0x23940BC", VA = "0x7BBCB940BC")]
		private void ProcessEventState()
		{
		}

		// Token: 0x0600B461 RID: 46177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B461")]
		[Address(RVA = "0x23941C4", Offset = "0x23941C4", VA = "0x7BBCB941C4")]
		private void ProcseeEventSettingInfo(CSGetRampageSettingRes res)
		{
		}

		// Token: 0x0600B462 RID: 46178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B462")]
		[Address(RVA = "0x23941D4", Offset = "0x23941D4", VA = "0x7BBCB941D4")]
		private void ProcessRampagePoints(CSGetProcessRampagePointsRes res)
		{
		}

		// Token: 0x0600B463 RID: 46179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B463")]
		[Address(RVA = "0x23941E4", Offset = "0x23941E4", VA = "0x7BBCB941E4")]
		private void ProcessRampageRank(CSGetRampageRankRes res)
		{
		}

		// Token: 0x0600B464 RID: 46180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B464")]
		[Address(RVA = "0x2393F20", Offset = "0x2393F20", VA = "0x7BBCB93F20")]
		private void RefreshEventState()
		{
		}

		// Token: 0x0600B465 RID: 46181 RVA: 0x000332E8 File Offset: 0x000314E8
		[Token(Token = "0x600B465")]
		[Address(RVA = "0x23941F4", Offset = "0x23941F4", VA = "0x7BBCB941F4")]
		public ulong GetSelfPoints()
		{
			return 0UL;
		}

		// Token: 0x0600B466 RID: 46182 RVA: 0x00033300 File Offset: 0x00031500
		[Token(Token = "0x600B466")]
		[Address(RVA = "0x239420C", Offset = "0x239420C", VA = "0x7BBCB9420C")]
		public uint GetSelfRank()
		{
			return 0U;
		}

		// Token: 0x0600B467 RID: 46183 RVA: 0x00033318 File Offset: 0x00031518
		[Token(Token = "0x600B467")]
		[Address(RVA = "0x2394224", Offset = "0x2394224", VA = "0x7BBCB94224")]
		public ulong GetFactionPoints(ELimitedEvent.RampageFaction faction)
		{
			return 0UL;
		}

		// Token: 0x0600B468 RID: 46184 RVA: 0x00033330 File Offset: 0x00031530
		[Token(Token = "0x600B468")]
		[Address(RVA = "0x2394308", Offset = "0x2394308", VA = "0x7BBCB94308")]
		public bool SelfFactionWin()
		{
			return default(bool);
		}

		// Token: 0x0600B469 RID: 46185 RVA: 0x00033348 File Offset: 0x00031548
		[Token(Token = "0x600B469")]
		[Address(RVA = "0x239436C", Offset = "0x239436C", VA = "0x7BBCB9436C")]
		public ELimitedEvent.RampageFaction GetWinFactionType()
		{
			return ELimitedEvent.RampageFaction.RampageFaction_NONE;
		}

		// Token: 0x0600B46A RID: 46186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B46A")]
		[Address(RVA = "0x23943B4", Offset = "0x23943B4", VA = "0x7BBCB943B4")]
		public BigEventOpenInfoDesc GetEventOpenInfo(ELimitedEvent.EventState state)
		{
			return null;
		}

		// Token: 0x0600B46B RID: 46187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B46B")]
		[Address(RVA = "0x2394490", Offset = "0x2394490", VA = "0x7BBCB94490")]
		public List<BigEventStoreCommodityDesc> GetStoreItemsList(uint level)
		{
			return null;
		}

		// Token: 0x0600B46C RID: 46188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B46C")]
		[Address(RVA = "0x239459C", Offset = "0x239459C", VA = "0x7BBCB9459C")]
		public RampageRankDesc GetRampageRankDesc(uint rank)
		{
			return null;
		}

		// Token: 0x0600B46D RID: 46189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B46D")]
		[Address(RVA = "0x2394674", Offset = "0x2394674", VA = "0x7BBCB94674")]
		public List<RampageRankDesc> GetAllRampageRankDesc()
		{
			return null;
		}

		// Token: 0x0600B46E RID: 46190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B46E")]
		[Address(RVA = "0x239467C", Offset = "0x239467C", VA = "0x7BBCB9467C")]
		public void RampagePointsUpdate(ulong points, uint rank)
		{
		}

		// Token: 0x0600B46F RID: 46191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B46F")]
		[Address(RVA = "0x23946E8", Offset = "0x23946E8", VA = "0x7BBCB946E8")]
		private void UpdateSelfPoints(ulong points)
		{
		}

		// Token: 0x0600B470 RID: 46192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B470")]
		[Address(RVA = "0x2394774", Offset = "0x2394774", VA = "0x7BBCB94774")]
		private void UpdateSelfRank(uint rank)
		{
		}

		// Token: 0x0600B471 RID: 46193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B471")]
		[Address(RVA = "0x23949E0", Offset = "0x23949E0", VA = "0x7BBCB949E0")]
		private void RefreshRampageTipsNum()
		{
		}

		// Token: 0x0600B472 RID: 46194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B472")]
		[Address(RVA = "0x2394AA8", Offset = "0x2394AA8", VA = "0x7BBCB94AA8")]
		public void UpdateRampagePeakDayAward()
		{
		}

		// Token: 0x0600B473 RID: 46195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B473")]
		[Address(RVA = "0x2394820", Offset = "0x2394820", VA = "0x7BBCB94820")]
		public void SetLobbyRankUpGuide(uint rank)
		{
		}

		// Token: 0x0600B474 RID: 46196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B474")]
		[Address(RVA = "0x23948A0", Offset = "0x23948A0", VA = "0x7BBCB948A0")]
		public void SetStoreRankUpGuide(uint rank)
		{
		}

		// Token: 0x0600B475 RID: 46197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B475")]
		[Address(RVA = "0x2394CE4", Offset = "0x2394CE4", VA = "0x7BBCB94CE4")]
		public void SetLobbyStoreGuide()
		{
		}

		// Token: 0x0600B476 RID: 46198 RVA: 0x00033360 File Offset: 0x00031560
		[Token(Token = "0x600B476")]
		[Address(RVA = "0x2394D58", Offset = "0x2394D58", VA = "0x7BBCB94D58")]
		public int GetLobbyRankUpGuide()
		{
			return 0;
		}

		// Token: 0x0600B477 RID: 46199 RVA: 0x00033378 File Offset: 0x00031578
		[Token(Token = "0x600B477")]
		[Address(RVA = "0x2394DCC", Offset = "0x2394DCC", VA = "0x7BBCB94DCC")]
		public int GetStoreRankUpGuide()
		{
			return 0;
		}

		// Token: 0x0600B478 RID: 46200 RVA: 0x00033390 File Offset: 0x00031590
		[Token(Token = "0x600B478")]
		[Address(RVA = "0x2394E40", Offset = "0x2394E40", VA = "0x7BBCB94E40")]
		public int GetLobbyStoreGuide()
		{
			return 0;
		}

		// Token: 0x0600B479 RID: 46201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B479")]
		[Address(RVA = "0x2394920", Offset = "0x2394920", VA = "0x7BBCB94920")]
		public void RefreshShopTipsNum(int num)
		{
		}

		// Token: 0x0600B47A RID: 46202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B47A")]
		[Address(RVA = "0x2394EB4", Offset = "0x2394EB4", VA = "0x7BBCB94EB4")]
		public void RefreshAwardTipsNum(int num)
		{
		}

		// Token: 0x0600B47B RID: 46203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B47B")]
		[Address(RVA = "0x2394F74", Offset = "0x2394F74", VA = "0x7BBCB94F74")]
		public void RefreshSignInTipsNum(int num)
		{
		}

		// Token: 0x0600B47C RID: 46204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B47C")]
		[Address(RVA = "0x2394C24", Offset = "0x2394C24", VA = "0x7BBCB94C24")]
		public void RefreshPeakDayAwardTipsNum(int num)
		{
		}

		// Token: 0x0600B47D RID: 46205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B47D")]
		[Address(RVA = "0x2395034", Offset = "0x2395034", VA = "0x7BBCB95034")]
		public void GetStoreRes(ELimitedEvent.RampageFaction sideType)
		{
		}

		// Token: 0x0600B47E RID: 46206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B47E")]
		[Address(RVA = "0x2395208", Offset = "0x2395208", VA = "0x7BBCB95208", Slot = "14")]
		public void OnProcessEventOpenInfo()
		{
		}

		// Token: 0x0600B47F RID: 46207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B47F")]
		[Address(RVA = "0x239527C", Offset = "0x239527C", VA = "0x7BBCB9527C")]
		public void RequestAccountRampageInfo(uint option = 0U)
		{
		}

		// Token: 0x0600B480 RID: 46208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B480")]
		[Address(RVA = "0x23953FC", Offset = "0x23953FC", VA = "0x7BBCB953FC")]
		public void RequestChooseFaction(ELimitedEvent.RampageFaction faction)
		{
		}

		// Token: 0x0600B481 RID: 46209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B481")]
		[Address(RVA = "0x23955E0", Offset = "0x23955E0", VA = "0x7BBCB955E0")]
		public void RequesePurchase(BigEventStoreCommodityDesc desc, uint cnt = 1U)
		{
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B482")]
		[Address(RVA = "0x2395ACC", Offset = "0x2395ACC", VA = "0x7BBCB95ACC")]
		public HttpRequest RequestRampageConfig(uint option = 0U)
		{
			return null;
		}

		// Token: 0x0600B483 RID: 46211 RVA: 0x000333A8 File Offset: 0x000315A8
		[Token(Token = "0x600B483")]
		[Address(RVA = "0x2395C4C", Offset = "0x2395C4C", VA = "0x7BBCB95C4C")]
		public int SortStoreItem(BigEventStoreCommodityDesc a, BigEventStoreCommodityDesc b)
		{
			return 0;
		}

		// Token: 0x0600B484 RID: 46212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B484")]
		[Address(RVA = "0x2395EEC", Offset = "0x2395EEC", VA = "0x7BBCB95EEC")]
		public UIModelRampage()
		{
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B485")]
		[Address(RVA = "0x239617C", Offset = "0x239617C", VA = "0x7BBCB9617C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146DDC", Offset = "0x1146DDC")]
		private void <GetStoreRes>b__57_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B486 RID: 46214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B486")]
		[Address(RVA = "0x2396374", Offset = "0x2396374", VA = "0x7BBCB96374")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146DEC", Offset = "0x1146DEC")]
		private void <RequestAccountRampageInfo>b__59_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B487")]
		[Address(RVA = "0x2396484", Offset = "0x2396484", VA = "0x7BBCB96484")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146DFC", Offset = "0x1146DFC")]
		private void <RequestRampageConfig>b__62_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B6DC RID: 46812
		[Token(Token = "0x400B6DC")]
		public const uint Prop_PlayerInfoUpdate = 2U;

		// Token: 0x0400B6DD RID: 46813
		[Token(Token = "0x400B6DD")]
		public const uint Prop_PurchaseSuccess = 4U;

		// Token: 0x0400B6DE RID: 46814
		[Token(Token = "0x400B6DE")]
		public const uint Prop_StoreItemsRefresh = 8U;

		// Token: 0x0400B6DF RID: 46815
		[Token(Token = "0x400B6DF")]
		public const uint Prop_GetEventStateInfoFinish = 16U;

		// Token: 0x0400B6E0 RID: 46816
		[Token(Token = "0x400B6E0")]
		public const uint Prop_SelfPointsUpdate = 32U;

		// Token: 0x0400B6E1 RID: 46817
		[Token(Token = "0x400B6E1")]
		public const uint Prop_SelfRankUpdate = 64U;

		// Token: 0x0400B6E2 RID: 46818
		[Token(Token = "0x400B6E2")]
		[FieldOffset(Offset = "0x18")]
		private ELimitedEvent.EventState m_EventState;

		// Token: 0x0400B6E3 RID: 46819
		[Token(Token = "0x400B6E3")]
		[FieldOffset(Offset = "0x20")]
		private List<LimitedEventStore> m_StoreList;

		// Token: 0x0400B6E4 RID: 46820
		[Token(Token = "0x400B6E4")]
		[FieldOffset(Offset = "0x28")]
		private List<BigEventOpenInfoDesc> m_EventOpenInfosList;

		// Token: 0x0400B6E5 RID: 46821
		[Token(Token = "0x400B6E5")]
		[FieldOffset(Offset = "0x30")]
		private RampageSettingDesc m_RampageSettingDesc;

		// Token: 0x0400B6E6 RID: 46822
		[Token(Token = "0x400B6E6")]
		[FieldOffset(Offset = "0x38")]
		private List<RampagePoints> m_RampagePoints;

		// Token: 0x0400B6E7 RID: 46823
		[Token(Token = "0x400B6E7")]
		[FieldOffset(Offset = "0x40")]
		private CSGetPlayerRampageInfoRes m_RampagePlayerInfo;

		// Token: 0x0400B6E8 RID: 46824
		[Token(Token = "0x400B6E8")]
		[FieldOffset(Offset = "0x48")]
		private List<RampageRankDesc> m_RampageRankDesc;

		// Token: 0x0400B6E9 RID: 46825
		[Token(Token = "0x400B6E9")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<ELimitedEvent.RampageFaction, string> FactionNameDict;

		// Token: 0x0400B6EA RID: 46826
		[Token(Token = "0x400B6EA")]
		[FieldOffset(Offset = "0x58")]
		private uint m_EvenID;

		// Token: 0x0400B6EB RID: 46827
		[Token(Token = "0x400B6EB")]
		[FieldOffset(Offset = "0x60")]
		private string m_LobbyRankUpGuide;

		// Token: 0x0400B6EC RID: 46828
		[Token(Token = "0x400B6EC")]
		[FieldOffset(Offset = "0x68")]
		private string m_StoreRankUpGuide;

		// Token: 0x0400B6ED RID: 46829
		[Token(Token = "0x400B6ED")]
		[FieldOffset(Offset = "0x70")]
		private string m_LobbyStoreGuide;

		// Token: 0x02001FC3 RID: 8131
		[Token(Token = "0x2001FC3")]
		public class NotifyArgsPurchase
		{
			// Token: 0x0600B488 RID: 46216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B488")]
			[Address(RVA = "0x2397050", Offset = "0x2397050", VA = "0x7BBCB97050")]
			public NotifyArgsPurchase()
			{
			}

			// Token: 0x0400B6EE RID: 46830
			[Token(Token = "0x400B6EE")]
			[FieldOffset(Offset = "0x10")]
			public uint skuID;
		}

		// Token: 0x02001FC4 RID: 8132
		[Token(Token = "0x2001FC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD574", Offset = "0x10FD574")]
		private sealed class <>c__DisplayClass35_0
		{
			// Token: 0x0600B489 RID: 46217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B489")]
			[Address(RVA = "0x2394300", Offset = "0x2394300", VA = "0x7BBCB94300")]
			public <>c__DisplayClass35_0()
			{
			}

			// Token: 0x0600B48A RID: 46218 RVA: 0x000333C0 File Offset: 0x000315C0
			[Token(Token = "0x600B48A")]
			[Address(RVA = "0x2396664", Offset = "0x2396664", VA = "0x7BBCB96664")]
			internal bool <GetFactionPoints>b__0(RampagePoints e)
			{
				return default(bool);
			}

			// Token: 0x0400B6EF RID: 46831
			[Token(Token = "0x400B6EF")]
			[FieldOffset(Offset = "0x10")]
			public ELimitedEvent.RampageFaction faction;
		}

		// Token: 0x02001FC5 RID: 8133
		[Token(Token = "0x2001FC5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD584", Offset = "0x10FD584")]
		private sealed class <>c__DisplayClass38_0
		{
			// Token: 0x0600B48B RID: 46219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B48B")]
			[Address(RVA = "0x2394488", Offset = "0x2394488", VA = "0x7BBCB94488")]
			public <>c__DisplayClass38_0()
			{
			}

			// Token: 0x0600B48C RID: 46220 RVA: 0x000333D8 File Offset: 0x000315D8
			[Token(Token = "0x600B48C")]
			[Address(RVA = "0x23966A0", Offset = "0x23966A0", VA = "0x7BBCB966A0")]
			internal bool <GetEventOpenInfo>b__0(BigEventOpenInfoDesc info)
			{
				return default(bool);
			}

			// Token: 0x0400B6F0 RID: 46832
			[Token(Token = "0x400B6F0")]
			[FieldOffset(Offset = "0x10")]
			public ELimitedEvent.EventState state;
		}

		// Token: 0x02001FC6 RID: 8134
		[Token(Token = "0x2001FC6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD594", Offset = "0x10FD594")]
		private sealed class <>c__DisplayClass39_0
		{
			// Token: 0x0600B48D RID: 46221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B48D")]
			[Address(RVA = "0x2394594", Offset = "0x2394594", VA = "0x7BBCB94594")]
			public <>c__DisplayClass39_0()
			{
			}

			// Token: 0x0600B48E RID: 46222 RVA: 0x000333F0 File Offset: 0x000315F0
			[Token(Token = "0x600B48E")]
			[Address(RVA = "0x23966DC", Offset = "0x23966DC", VA = "0x7BBCB966DC")]
			internal bool <GetStoreItemsList>b__0(LimitedEventStore store)
			{
				return default(bool);
			}

			// Token: 0x0400B6F1 RID: 46833
			[Token(Token = "0x400B6F1")]
			[FieldOffset(Offset = "0x10")]
			public uint level;
		}

		// Token: 0x02001FC7 RID: 8135
		[Token(Token = "0x2001FC7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD5A4", Offset = "0x10FD5A4")]
		private sealed class <>c__DisplayClass40_0
		{
			// Token: 0x0600B48F RID: 46223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B48F")]
			[Address(RVA = "0x239466C", Offset = "0x239466C", VA = "0x7BBCB9466C")]
			public <>c__DisplayClass40_0()
			{
			}

			// Token: 0x0600B490 RID: 46224 RVA: 0x00033408 File Offset: 0x00031608
			[Token(Token = "0x600B490")]
			[Address(RVA = "0x2396728", Offset = "0x2396728", VA = "0x7BBCB96728")]
			internal bool <GetRampageRankDesc>b__0(RampageRankDesc desc)
			{
				return default(bool);
			}

			// Token: 0x0400B6F2 RID: 46834
			[Token(Token = "0x400B6F2")]
			[FieldOffset(Offset = "0x10")]
			public uint rank;
		}

		// Token: 0x02001FC8 RID: 8136
		[Token(Token = "0x2001FC8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD5B4", Offset = "0x10FD5B4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600B492 RID: 46226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B492")]
			[Address(RVA = "0x23965F4", Offset = "0x23965F4", VA = "0x7BBCB965F4")]
			public <>c()
			{
			}

			// Token: 0x0600B493 RID: 46227 RVA: 0x00033420 File Offset: 0x00031620
			[Token(Token = "0x600B493")]
			[Address(RVA = "0x23965FC", Offset = "0x23965FC", VA = "0x7BBCB965FC")]
			internal int <GetStoreRes>b__57_1(LimitedEventStore a, LimitedEventStore b)
			{
				return 0;
			}

			// Token: 0x0400B6F3 RID: 46835
			[Token(Token = "0x400B6F3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelRampage.<>c <>9;

			// Token: 0x0400B6F4 RID: 46836
			[Token(Token = "0x400B6F4")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<LimitedEventStore> <>9__57_1;
		}

		// Token: 0x02001FC9 RID: 8137
		[Token(Token = "0x2001FC9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD5C4", Offset = "0x10FD5C4")]
		private sealed class <>c__DisplayClass60_0
		{
			// Token: 0x0600B494 RID: 46228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B494")]
			[Address(RVA = "0x23955D8", Offset = "0x23955D8", VA = "0x7BBCB955D8")]
			public <>c__DisplayClass60_0()
			{
			}

			// Token: 0x0600B495 RID: 46229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B495")]
			[Address(RVA = "0x2396764", Offset = "0x2396764", VA = "0x7BBCB96764")]
			internal void <RequestChooseFaction>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B6F5 RID: 46837
			[Token(Token = "0x400B6F5")]
			[FieldOffset(Offset = "0x10")]
			public UIModelRampage <>4__this;

			// Token: 0x0400B6F6 RID: 46838
			[Token(Token = "0x400B6F6")]
			[FieldOffset(Offset = "0x18")]
			public ELimitedEvent.RampageFaction faction;
		}

		// Token: 0x02001FCA RID: 8138
		[Token(Token = "0x2001FCA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD5D4", Offset = "0x10FD5D4")]
		private sealed class <>c__DisplayClass61_0
		{
			// Token: 0x0600B496 RID: 46230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B496")]
			[Address(RVA = "0x2395AC4", Offset = "0x2395AC4", VA = "0x7BBCB95AC4")]
			public <>c__DisplayClass61_0()
			{
			}

			// Token: 0x0600B497 RID: 46231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B497")]
			[Address(RVA = "0x23969CC", Offset = "0x23969CC", VA = "0x7BBCB969CC")]
			internal void <RequesePurchase>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0600B498 RID: 46232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B498")]
			[Address(RVA = "0x2397058", Offset = "0x2397058", VA = "0x7BBCB97058")]
			internal void <RequesePurchase>b__1()
			{
			}

			// Token: 0x0400B6F7 RID: 46839
			[Token(Token = "0x400B6F7")]
			[FieldOffset(Offset = "0x10")]
			public BigEventStoreCommodityDesc desc;

			// Token: 0x0400B6F8 RID: 46840
			[Token(Token = "0x400B6F8")]
			[FieldOffset(Offset = "0x18")]
			public uint cnt;

			// Token: 0x0400B6F9 RID: 46841
			[Token(Token = "0x400B6F9")]
			[FieldOffset(Offset = "0x20")]
			public UIModelRampage <>4__this;

			// Token: 0x0400B6FA RID: 46842
			[Token(Token = "0x400B6FA")]
			[FieldOffset(Offset = "0x28")]
			public Action <>9__1;
		}
	}
}
