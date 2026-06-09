using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004FC RID: 1276
	[Token(Token = "0x20004FC")]
	[ProtoContract]
	public class ERoom
	{
		// Token: 0x06001FD3 RID: 8147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0x24A2DB0", Offset = "0x24A2DB0", VA = "0x7BBCCA2DB0")]
		public ERoom()
		{
		}

		// Token: 0x020004FD RID: 1277
		[Token(Token = "0x20004FD")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x04001784 RID: 6020
			[Token(Token = "0x4001784")]
			Proto_NONE,
			// Token: 0x04001785 RID: 6021
			[Token(Token = "0x4001785")]
			Proto_ROOMLIST,
			// Token: 0x04001786 RID: 6022
			[Token(Token = "0x4001786")]
			Proto_CREATE,
			// Token: 0x04001787 RID: 6023
			[Token(Token = "0x4001787")]
			Proto_JOIN,
			// Token: 0x04001788 RID: 6024
			[Token(Token = "0x4001788")]
			Proto_SPECTATE,
			// Token: 0x04001789 RID: 6025
			[Token(Token = "0x4001789")]
			Proto_JOIN_NTF,
			// Token: 0x0400178A RID: 6026
			[Token(Token = "0x400178A")]
			Proto_LEAVE,
			// Token: 0x0400178B RID: 6027
			[Token(Token = "0x400178B")]
			Proto_LEAVE_NTF,
			// Token: 0x0400178C RID: 6028
			[Token(Token = "0x400178C")]
			Proto_DISMISS_NTF,
			// Token: 0x0400178D RID: 6029
			[Token(Token = "0x400178D")]
			Proto_KICK,
			// Token: 0x0400178E RID: 6030
			[Token(Token = "0x400178E")]
			Proto_KICK_NTF,
			// Token: 0x0400178F RID: 6031
			[Token(Token = "0x400178F")]
			Proto_START,
			// Token: 0x04001790 RID: 6032
			[Token(Token = "0x4001790")]
			Proto_ROOMINFO,
			// Token: 0x04001791 RID: 6033
			[Token(Token = "0x4001791")]
			Proto_CHANGE,
			// Token: 0x04001792 RID: 6034
			[Token(Token = "0x4001792")]
			Proto_CHANGE_NTF,
			// Token: 0x04001793 RID: 6035
			[Token(Token = "0x4001793")]
			Proto_DROPOMATCH,
			// Token: 0x04001794 RID: 6036
			[Token(Token = "0x4001794")]
			Proto_MATCHMAKINGSUSS_NTF,
			// Token: 0x04001795 RID: 6037
			[Token(Token = "0x4001795")]
			Proto_ROOMSTATE_NTF,
			// Token: 0x04001796 RID: 6038
			[Token(Token = "0x4001796")]
			Proto_CHECKINGAMEPLAYER,
			// Token: 0x04001797 RID: 6039
			[Token(Token = "0x4001797")]
			Proto_CLEARINGAMEPLAYER,
			// Token: 0x04001798 RID: 6040
			[Token(Token = "0x4001798")]
			Proto_SWITCHSEAT,
			// Token: 0x04001799 RID: 6041
			[Token(Token = "0x4001799")]
			Proto_SWITCHSEAT_NTF,
			// Token: 0x0400179A RID: 6042
			[Token(Token = "0x400179A")]
			Proto_INVITE,
			// Token: 0x0400179B RID: 6043
			[Token(Token = "0x400179B")]
			Proto_INVITE_NTF,
			// Token: 0x0400179C RID: 6044
			[Token(Token = "0x400179C")]
			Proto_SETREADY,
			// Token: 0x0400179D RID: 6045
			[Token(Token = "0x400179D")]
			Proto_SETREADY_NTF,
			// Token: 0x0400179E RID: 6046
			[Token(Token = "0x400179E")]
			Proto_REAL_CREATE,
			// Token: 0x0400179F RID: 6047
			[Token(Token = "0x400179F")]
			Proto_ADMIN_SET_ICON,
			// Token: 0x040017A0 RID: 6048
			[Token(Token = "0x40017A0")]
			Proto_ADMIN_DISMISS_ROOM,
			// Token: 0x040017A1 RID: 6049
			[Token(Token = "0x40017A1")]
			Proto_ANTIADDICTION_NFT,
			// Token: 0x040017A2 RID: 6050
			[Token(Token = "0x40017A2")]
			proto_TEAMMATEHEATING_NFT,
			// Token: 0x040017A3 RID: 6051
			[Token(Token = "0x40017A3")]
			Proto_ADMIN_GET_CUSTOMROOM_MATCHSTATS,
			// Token: 0x040017A4 RID: 6052
			[Token(Token = "0x40017A4")]
			Proto_ROOM_CREATE_RULE,
			// Token: 0x040017A5 RID: 6053
			[Token(Token = "0x40017A5")]
			Proto_CHANGEAVAILABLEMAPS,
			// Token: 0x040017A6 RID: 6054
			[Token(Token = "0x40017A6")]
			Proto_CHANGEAVAILABLEMAPS_NTF,
			// Token: 0x040017A7 RID: 6055
			[Token(Token = "0x40017A7")]
			Proto_EMULATORCHECK_NTF,
			// Token: 0x040017A8 RID: 6056
			[Token(Token = "0x40017A8")]
			proto_OWNERSWITCHGROUP,
			// Token: 0x040017A9 RID: 6057
			[Token(Token = "0x40017A9")]
			proto_OWNERSWITCHGROUP_NTF,
			// Token: 0x040017AA RID: 6058
			[Token(Token = "0x40017AA")]
			Proto_ROLECHECK_NTF,
			// Token: 0x040017AB RID: 6059
			[Token(Token = "0x40017AB")]
			Proto_COUNTDOWN,
			// Token: 0x040017AC RID: 6060
			[Token(Token = "0x40017AC")]
			Proto_COUNTDOWN_NTF
		}

		// Token: 0x020004FE RID: 1278
		[Token(Token = "0x20004FE")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040017AE RID: 6062
			[Token(Token = "0x40017AE")]
			ErrCode_SUSS,
			// Token: 0x040017AF RID: 6063
			[Token(Token = "0x40017AF")]
			ErrCode_NOROOM,
			// Token: 0x040017B0 RID: 6064
			[Token(Token = "0x40017B0")]
			ErrCode_REACHMAXMEMBERS,
			// Token: 0x040017B1 RID: 6065
			[Token(Token = "0x40017B1")]
			ErrCode_REACHMAXSPECTATORS,
			// Token: 0x040017B2 RID: 6066
			[Token(Token = "0x40017B2")]
			ErrCode_ALREADYINROOM,
			// Token: 0x040017B3 RID: 6067
			[Token(Token = "0x40017B3")]
			ErrCode_NOTINROOM,
			// Token: 0x040017B4 RID: 6068
			[Token(Token = "0x40017B4")]
			ErrCode_ROOMINGAME,
			// Token: 0x040017B5 RID: 6069
			[Token(Token = "0x40017B5")]
			ErrCode_ROOMNOTINGAME,
			// Token: 0x040017B6 RID: 6070
			[Token(Token = "0x40017B6")]
			ErrCode_CANNOTCREATEROOM,
			// Token: 0x040017B7 RID: 6071
			[Token(Token = "0x40017B7")]
			ErrCode_NOGAMESERVERAVAILABLE,
			// Token: 0x040017B8 RID: 6072
			[Token(Token = "0x40017B8")]
			ErrCode_INVALIDCODE,
			// Token: 0x040017B9 RID: 6073
			[Token(Token = "0x40017B9")]
			ErrCode_CANNOTKICK,
			// Token: 0x040017BA RID: 6074
			[Token(Token = "0x40017BA")]
			ErrCode_NOTOWNER,
			// Token: 0x040017BB RID: 6075
			[Token(Token = "0x40017BB")]
			ErrCode_GENMATCHIDFAIL,
			// Token: 0x040017BC RID: 6076
			[Token(Token = "0x40017BC")]
			ErrCode_LOGINGAMESERVERTIMEOUT,
			// Token: 0x040017BD RID: 6077
			[Token(Token = "0x40017BD")]
			ErrCode_CREATEROOMFAIL,
			// Token: 0x040017BE RID: 6078
			[Token(Token = "0x40017BE")]
			ErrCode_JOININVALIDPLAYERCNT,
			// Token: 0x040017BF RID: 6079
			[Token(Token = "0x40017BF")]
			ErrCode_DIRTYWORD,
			// Token: 0x040017C0 RID: 6080
			[Token(Token = "0x40017C0")]
			ErrCode_SEATOCCUPIED,
			// Token: 0x040017C1 RID: 6081
			[Token(Token = "0x40017C1")]
			ErrCode_CANNOTSWITCHSEAT,
			// Token: 0x040017C2 RID: 6082
			[Token(Token = "0x40017C2")]
			ErrCode_INVALIDMEMBERNUM,
			// Token: 0x040017C3 RID: 6083
			[Token(Token = "0x40017C3")]
			ErrCode_NOTENOUGHROOMCARD,
			// Token: 0x040017C4 RID: 6084
			[Token(Token = "0x40017C4")]
			ErrCode_INVALIDOPTIONS,
			// Token: 0x040017C5 RID: 6085
			[Token(Token = "0x40017C5")]
			ErrCode_CANNOTINVITESELF,
			// Token: 0x040017C6 RID: 6086
			[Token(Token = "0x40017C6")]
			ErrCode_INVALIDROOMTYPE,
			// Token: 0x040017C7 RID: 6087
			[Token(Token = "0x40017C7")]
			ErrCode_INVITEEALREADYINGROUP,
			// Token: 0x040017C8 RID: 6088
			[Token(Token = "0x40017C8")]
			ErrCode_INVITEEALREADYINROOM,
			// Token: 0x040017C9 RID: 6089
			[Token(Token = "0x40017C9")]
			ErrCode_INVITEEALREADYINGAME,
			// Token: 0x040017CA RID: 6090
			[Token(Token = "0x40017CA")]
			ErrCode_INVITEEALREADYOFFLINE,
			// Token: 0x040017CB RID: 6091
			[Token(Token = "0x40017CB")]
			ErrCode_NOTENOUGHMEMEBERS,
			// Token: 0x040017CC RID: 6092
			[Token(Token = "0x40017CC")]
			ErrCode_REACHMAXINGAMEROOMNUMLIMIT,
			// Token: 0x040017CD RID: 6093
			[Token(Token = "0x40017CD")]
			ErrCode_NEGATIVEGEMS,
			// Token: 0x040017CE RID: 6094
			[Token(Token = "0x40017CE")]
			ErrCode_ANTIADDICTIONBAN,
			// Token: 0x040017CF RID: 6095
			[Token(Token = "0x40017CF")]
			ErrCode_ROOMCENTERNOTREADY,
			// Token: 0x040017D0 RID: 6096
			[Token(Token = "0x40017D0")]
			ErrCode_INVITEEALREADYINTRAINING,
			// Token: 0x040017D1 RID: 6097
			[Token(Token = "0x40017D1")]
			ErrCode_MAPINVALIDFORSOMEMEMBERS,
			// Token: 0x040017D2 RID: 6098
			[Token(Token = "0x40017D2")]
			ErrCode_REOPENIDNOTEXISTS,
			// Token: 0x040017D3 RID: 6099
			[Token(Token = "0x40017D3")]
			ErrCode_EMULATORCHECKFAILED,
			// Token: 0x040017D4 RID: 6100
			[Token(Token = "0x40017D4")]
			ErrCode_GROUPOCCUPIED,
			// Token: 0x040017D5 RID: 6101
			[Token(Token = "0x40017D5")]
			ErrCode_REACHMAXBATCHROOMNUMLIMIT,
			// Token: 0x040017D6 RID: 6102
			[Token(Token = "0x40017D6")]
			ErrCode_NOCREATEROLE,
			// Token: 0x040017D7 RID: 6103
			[Token(Token = "0x40017D7")]
			ErrCode_NOJOINROLE
		}

		// Token: 0x020004FF RID: 1279
		[Token(Token = "0x20004FF")]
		[ProtoContract]
		public enum Type
		{
			// Token: 0x040017D9 RID: 6105
			[Token(Token = "0x40017D9")]
			Type_NONE,
			// Token: 0x040017DA RID: 6106
			[Token(Token = "0x40017DA")]
			Type_CASUAL,
			// Token: 0x040017DB RID: 6107
			[Token(Token = "0x40017DB")]
			Type_LEAGUE_NORMAL,
			// Token: 0x040017DC RID: 6108
			[Token(Token = "0x40017DC")]
			Type_LEAGUE_BATCH = 6,
			// Token: 0x040017DD RID: 6109
			[Token(Token = "0x40017DD")]
			Type_WEREWOLVES
		}

		// Token: 0x02000500 RID: 1280
		[Token(Token = "0x2000500")]
		[ProtoContract]
		public enum TabType
		{
			// Token: 0x040017DF RID: 6111
			[Token(Token = "0x40017DF")]
			TabType_NONE,
			// Token: 0x040017E0 RID: 6112
			[Token(Token = "0x40017E0")]
			TabType_NORMAL,
			// Token: 0x040017E1 RID: 6113
			[Token(Token = "0x40017E1")]
			TabType_LEAGUE,
			// Token: 0x040017E2 RID: 6114
			[Token(Token = "0x40017E2")]
			TabType_WEREWOLVES
		}

		// Token: 0x02000501 RID: 1281
		[Token(Token = "0x2000501")]
		[ProtoContract]
		public enum PlayerRole
		{
			// Token: 0x040017E4 RID: 6116
			[Token(Token = "0x40017E4")]
			PlayerRole_NONE,
			// Token: 0x040017E5 RID: 6117
			[Token(Token = "0x40017E5")]
			PlayerRole_MEMBER,
			// Token: 0x040017E6 RID: 6118
			[Token(Token = "0x40017E6")]
			PlayerRole_SPECTATOR
		}

		// Token: 0x02000502 RID: 1282
		[Token(Token = "0x2000502")]
		[ProtoContract]
		public enum PlayerState
		{
			// Token: 0x040017E8 RID: 6120
			[Token(Token = "0x40017E8")]
			PlayerState_IDLE,
			// Token: 0x040017E9 RID: 6121
			[Token(Token = "0x40017E9")]
			PlayerState_LOADING,
			// Token: 0x040017EA RID: 6122
			[Token(Token = "0x40017EA")]
			PlayerState_INGAME,
			// Token: 0x040017EB RID: 6123
			[Token(Token = "0x40017EB")]
			PlayerState_INGAME_CAN_RECONNECT
		}

		// Token: 0x02000503 RID: 1283
		[Token(Token = "0x2000503")]
		[ProtoContract]
		public enum State
		{
			// Token: 0x040017ED RID: 6125
			[Token(Token = "0x40017ED")]
			State_IDLE,
			// Token: 0x040017EE RID: 6126
			[Token(Token = "0x40017EE")]
			State_INGAME
		}

		// Token: 0x02000504 RID: 1284
		[Token(Token = "0x2000504")]
		[ProtoContract]
		public enum DismissReason
		{
			// Token: 0x040017F0 RID: 6128
			[Token(Token = "0x40017F0")]
			DismissReason_NONE,
			// Token: 0x040017F1 RID: 6129
			[Token(Token = "0x40017F1")]
			DismissReason_NORMAL,
			// Token: 0x040017F2 RID: 6130
			[Token(Token = "0x40017F2")]
			DismissReason_OFFLINE,
			// Token: 0x040017F3 RID: 6131
			[Token(Token = "0x40017F3")]
			DismissReason_TIMEOUT,
			// Token: 0x040017F4 RID: 6132
			[Token(Token = "0x40017F4")]
			DismissReason_ADMIN
		}

		// Token: 0x02000505 RID: 1285
		[Token(Token = "0x2000505")]
		[ProtoContract]
		public enum UpdateRoomEvent
		{
			// Token: 0x040017F6 RID: 6134
			[Token(Token = "0x40017F6")]
			UpdateRoomEvent_NONE,
			// Token: 0x040017F7 RID: 6135
			[Token(Token = "0x40017F7")]
			UpdateRoomEvent_INIT,
			// Token: 0x040017F8 RID: 6136
			[Token(Token = "0x40017F8")]
			UpdateRoomEvent_SEND_ALL_ROOMS,
			// Token: 0x040017F9 RID: 6137
			[Token(Token = "0x40017F9")]
			UpdateRoomEvent_STATE,
			// Token: 0x040017FA RID: 6138
			[Token(Token = "0x40017FA")]
			UpdateRoomEvent_OPTIONS,
			// Token: 0x040017FB RID: 6139
			[Token(Token = "0x40017FB")]
			UpdateRoomEvent_MEMBER_NUM,
			// Token: 0x040017FC RID: 6140
			[Token(Token = "0x40017FC")]
			UpdateRoomEvent_DISMISS_ROOM,
			// Token: 0x040017FD RID: 6141
			[Token(Token = "0x40017FD")]
			UpdateRoomEvent_CREATE_ROOM,
			// Token: 0x040017FE RID: 6142
			[Token(Token = "0x40017FE")]
			UpdateRoomEvent_EMPTY
		}
	}
}
