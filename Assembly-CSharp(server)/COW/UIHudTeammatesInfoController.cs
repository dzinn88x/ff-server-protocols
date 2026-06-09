using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001973 RID: 6515
	[Token(Token = "0x2001973")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F655C", Offset = "0x10F655C")]
	internal class UIHudTeammatesInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x060084A6 RID: 33958 RVA: 0x00023FB8 File Offset: 0x000221B8
		[Token(Token = "0x60084A6")]
		[Address(RVA = "0x15DE620", Offset = "0x15DE620", VA = "0x7BBBDDE620")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060084A7 RID: 33959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084A7")]
		[Address(RVA = "0x15DE670", Offset = "0x15DE670", VA = "0x7BBBDDE670", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060084A8 RID: 33960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084A8")]
		[Address(RVA = "0x15DECF8", Offset = "0x15DECF8", VA = "0x7BBBDDECF8", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x060084A9 RID: 33961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084A9")]
		[Address(RVA = "0x15DF674", Offset = "0x15DF674", VA = "0x7BBBDDF674", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x060084AA RID: 33962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084AA")]
		[Address(RVA = "0x15E0010", Offset = "0x15E0010", VA = "0x7BBBDE0010", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x060084AB RID: 33963 RVA: 0x00023FD0 File Offset: 0x000221D0
		[Token(Token = "0x60084AB")]
		[Address(RVA = "0x15E1A00", Offset = "0x15E1A00", VA = "0x7BBBDE1A00", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x060084AC RID: 33964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084AC")]
		[Address(RVA = "0x15E1A48", Offset = "0x15E1A48", VA = "0x7BBBDE1A48")]
		private void OnPlayerHPChanged(params object[] data)
		{
		}

		// Token: 0x060084AD RID: 33965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084AD")]
		[Address(RVA = "0x15E1CA4", Offset = "0x15E1CA4", VA = "0x7BBBDE1CA4")]
		private void OnPlayerKnockDownStateChanged(object[] data)
		{
		}

		// Token: 0x060084AE RID: 33966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084AE")]
		[Address(RVA = "0x15E2280", Offset = "0x15E2280", VA = "0x7BBBDE2280")]
		private void OnPlayerMaxHPChanged(params object[] data)
		{
		}

		// Token: 0x060084AF RID: 33967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084AF")]
		[Address(RVA = "0x15E2404", Offset = "0x15E2404", VA = "0x7BBBDE2404")]
		private void OnRemoveMapMark(object[] data)
		{
		}

		// Token: 0x060084B0 RID: 33968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084B0")]
		[Address(RVA = "0x15E2508", Offset = "0x15E2508", VA = "0x7BBBDE2508")]
		private void OnUpdateMapMark(object[] data)
		{
		}

		// Token: 0x060084B1 RID: 33969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084B1")]
		[Address(RVA = "0x15E260C", Offset = "0x15E260C", VA = "0x7BBBDE260C")]
		private void OnPlayerGetOnVehicle(object[] data)
		{
		}

		// Token: 0x060084B2 RID: 33970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084B2")]
		[Address(RVA = "0x15E2784", Offset = "0x15E2784", VA = "0x7BBBDE2784")]
		private void OnPlayerGetOffVehicle(object[] data)
		{
		}

		// Token: 0x060084B3 RID: 33971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084B3")]
		[Address(RVA = "0x15E28FC", Offset = "0x15E28FC", VA = "0x7BBBDE28FC")]
		private void OnTeammateKnockDown(object[] data)
		{
		}

		// Token: 0x060084B4 RID: 33972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084B4")]
		[Address(RVA = "0x15E2AC0", Offset = "0x15E2AC0", VA = "0x7BBBDE2AC0")]
		private void OnTeammateRevive(object[] data)
		{
		}

		// Token: 0x060084B5 RID: 33973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084B5")]
		[Address(RVA = "0x15E2C84", Offset = "0x15E2C84", VA = "0x7BBBDE2C84")]
		private void OnTeammatePhyxStateChanged(object[] data)
		{
		}

		// Token: 0x060084B6 RID: 33974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084B6")]
		[Address(RVA = "0x15E2EC8", Offset = "0x15E2EC8", VA = "0x7BBBDE2EC8")]
		private void OnTeammateQuit(object[] data)
		{
		}

		// Token: 0x060084B7 RID: 33975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084B7")]
		[Address(RVA = "0x15E3180", Offset = "0x15E3180", VA = "0x7BBBDE3180")]
		private void OnTeamateVadStateChange(object[] data)
		{
		}

		// Token: 0x060084B8 RID: 33976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084B8")]
		[Address(RVA = "0x15E3394", Offset = "0x15E3394", VA = "0x7BBBDE3394")]
		private void OnOwnPlayerChange(object[] data)
		{
		}

		// Token: 0x060084B9 RID: 33977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084B9")]
		[Address(RVA = "0x15E34F8", Offset = "0x15E34F8", VA = "0x7BBBDE34F8")]
		private void OnTeammateMuteChange(object[] data)
		{
		}

		// Token: 0x060084BA RID: 33978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084BA")]
		[Address(RVA = "0x15E370C", Offset = "0x15E370C", VA = "0x7BBBDE370C")]
		private void OnTeamateStateChange(object[] data)
		{
		}

		// Token: 0x060084BB RID: 33979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084BB")]
		[Address(RVA = "0x15E38A4", Offset = "0x15E38A4", VA = "0x7BBBDE38A4")]
		private void OnTeamInfoGet(object[] data)
		{
		}

		// Token: 0x060084BC RID: 33980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084BC")]
		[Address(RVA = "0x15DEA44", Offset = "0x15DEA44", VA = "0x7BBBDDEA44")]
		private void Repositon()
		{
		}

		// Token: 0x060084BD RID: 33981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084BD")]
		[Address(RVA = "0x15E3ECC", Offset = "0x15E3ECC", VA = "0x7BBBDE3ECC")]
		private void OnTeamParachuteModeChange(params object[] param)
		{
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084BE")]
		[Address(RVA = "0x15E418C", Offset = "0x15E418C", VA = "0x7BBBDE418C")]
		private void OnTrainingZoneChanged(params object[] param)
		{
		}

		// Token: 0x060084BF RID: 33983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084BF")]
		[Address(RVA = "0x15E4234", Offset = "0x15E4234", VA = "0x7BBBDE4234")]
		private void OnPlayerTrainingZoneChange(params object[] param)
		{
		}

		// Token: 0x060084C0 RID: 33984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084C0")]
		[Address(RVA = "0x15E4370", Offset = "0x15E4370", VA = "0x7BBBDE4370")]
		private void OnPlayerTokenChanged(params object[] param)
		{
		}

		// Token: 0x060084C1 RID: 33985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084C1")]
		[Address(RVA = "0x15E44E4", Offset = "0x15E44E4", VA = "0x7BBBDE44E4")]
		private void OnPlayerPickupOrDropBomb(params object[] param)
		{
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x00023FE8 File Offset: 0x000221E8
		[Token(Token = "0x60084C2")]
		[Address(RVA = "0x15E2128", Offset = "0x15E2128", VA = "0x7BBBDE2128")]
		private bool IsHadKnockDownTeammate()
		{
			return default(bool);
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084C3")]
		[Address(RVA = "0x15E1754", Offset = "0x15E1754", VA = "0x7BBBDE1754")]
		private void OnNewPhaseStarted(params object[] data)
		{
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084C4")]
		[Address(RVA = "0x15E4668", Offset = "0x15E4668", VA = "0x7BBBDE4668")]
		private void OnADS1v1Countdown(params object[] data)
		{
		}

		// Token: 0x060084C5 RID: 33989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084C5")]
		[Address(RVA = "0x15E4CB8", Offset = "0x15E4CB8", VA = "0x7BBBDE4CB8")]
		private void OnADS1v1Selected(params object[] data)
		{
		}

		// Token: 0x060084C6 RID: 33990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084C6")]
		[Address(RVA = "0x15E4F44", Offset = "0x15E4F44", VA = "0x7BBBDE4F44")]
		private void OnADSPlayerWin(params object[] param)
		{
		}

		// Token: 0x060084C7 RID: 33991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084C7")]
		[Address(RVA = "0x15E54B8", Offset = "0x15E54B8", VA = "0x7BBBDE54B8")]
		public UIHudTeammatesInfoController()
		{
		}

		// Token: 0x060084C8 RID: 33992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60084C8")]
		[Address(RVA = "0x15E5550", Offset = "0x15E5550", VA = "0x7BBBDE5550")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1143384", Offset = "0x1143384")]
		private void <OnADSPlayerWin>b__39_0()
		{
		}

		// Token: 0x040094C0 RID: 38080
		[Token(Token = "0x40094C0")]
		[FieldOffset(Offset = "0x58")]
		private UIHudTeammatesInfoView m_View;

		// Token: 0x040094C1 RID: 38081
		[Token(Token = "0x40094C1")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<{QAb\u0082~u, UIHudTeammateItem> m_Teammates;

		// Token: 0x040094C2 RID: 38082
		[Token(Token = "0x40094C2")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<ulong, {QAb\u0082~u> m_UserIdToPlayerId;

		// Token: 0x040094C3 RID: 38083
		[Token(Token = "0x40094C3")]
		[FieldOffset(Offset = "0x70")]
		private UIModelMatch m_MatchModel;

		// Token: 0x040094C4 RID: 38084
		[Token(Token = "0x40094C4")]
		[FieldOffset(Offset = "0x78")]
		private List<UIHudTeammateItem> m_ListTeammateItem;

		// Token: 0x040094C5 RID: 38085
		[Token(Token = "0x40094C5")]
		[FieldOffset(Offset = "0x80")]
		private bool m_RemoveOnQuit;

		// Token: 0x040094C6 RID: 38086
		[Token(Token = "0x40094C6")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<{QAb\u0082~u, ^|dlTwk> m_TeammateSycInfo;

		// Token: 0x02001974 RID: 6516
		[Token(Token = "0x2001974")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F6594", Offset = "0x10F6594")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060084CA RID: 33994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60084CA")]
			[Address(RVA = "0x15E5710", Offset = "0x15E5710", VA = "0x7BBBDE5710")]
			public <>c()
			{
			}

			// Token: 0x060084CB RID: 33995 RVA: 0x00024000 File Offset: 0x00022200
			[Token(Token = "0x60084CB")]
			[Address(RVA = "0x15E5718", Offset = "0x15E5718", VA = "0x7BBBDE5718")]
			internal int <Repositon>b__29_0(UIHudTeammateItem a, UIHudTeammateItem b)
			{
				return 0;
			}

			// Token: 0x040094C7 RID: 38087
			[Token(Token = "0x40094C7")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudTeammatesInfoController.<>c <>9;

			// Token: 0x040094C8 RID: 38088
			[Token(Token = "0x40094C8")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<UIHudTeammateItem> <>9__29_0;
		}
	}
}
