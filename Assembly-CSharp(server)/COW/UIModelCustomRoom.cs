using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001E3D RID: 7741
	[Token(Token = "0x2001E3D")]
	internal class UIModelCustomRoom : UIBaseModel
	{
		// Token: 0x0600A928 RID: 43304 RVA: 0x0002DC00 File Offset: 0x0002BE00
		[Token(Token = "0x600A928")]
		[Address(RVA = "0x233D07C", Offset = "0x233D07C", VA = "0x7BBCB3D07C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x0600A929 RID: 43305 RVA: 0x0002DC18 File Offset: 0x0002BE18
		// (set) Token: 0x0600A92A RID: 43306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B11")]
		public ECustomRoomRole MyRoomRole
		{
			[Token(Token = "0x600A929")]
			[Address(RVA = "0x233D084", Offset = "0x233D084", VA = "0x7BBCB3D084")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145F5C", Offset = "0x1145F5C")]
			get
			{
				return ECustomRoomRole.ECustomRoomRole_PLAYER;
			}
			[Token(Token = "0x600A92A")]
			[Address(RVA = "0x233D08C", Offset = "0x233D08C", VA = "0x7BBCB3D08C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145F6C", Offset = "0x1145F6C")]
			set
			{
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x0600A92B RID: 43307 RVA: 0x0002DC30 File Offset: 0x0002BE30
		// (set) Token: 0x0600A92C RID: 43308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B12")]
		public bool ShowNickName
		{
			[Token(Token = "0x600A92B")]
			[Address(RVA = "0x233D094", Offset = "0x233D094", VA = "0x7BBCB3D094")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A92C")]
			[Address(RVA = "0x233D09C", Offset = "0x233D09C", VA = "0x7BBCB3D09C")]
			set
			{
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x0600A92D RID: 43309 RVA: 0x0002DC48 File Offset: 0x0002BE48
		// (set) Token: 0x0600A92E RID: 43310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B13")]
		public ulong LatestTryConnectMatchId
		{
			[Token(Token = "0x600A92D")]
			[Address(RVA = "0x233D0A8", Offset = "0x233D0A8", VA = "0x7BBCB3D0A8")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600A92E")]
			[Address(RVA = "0x233D0B0", Offset = "0x233D0B0", VA = "0x7BBCB3D0B0")]
			set
			{
			}
		}

		// Token: 0x0600A92F RID: 43311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A92F")]
		[Address(RVA = "0x233D0B8", Offset = "0x233D0B8", VA = "0x7BBCB3D0B8", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600A930 RID: 43312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A930")]
		[Address(RVA = "0x233D8B4", Offset = "0x233D8B4", VA = "0x7BBCB3D8B4", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A931 RID: 43313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A931")]
		[Address(RVA = "0x233D9E4", Offset = "0x233D9E4", VA = "0x7BBCB3D9E4", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600A932 RID: 43314 RVA: 0x0002DC60 File Offset: 0x0002BE60
		[Token(Token = "0x17000B14")]
		public bool DisableAuthority
		{
			[Token(Token = "0x600A932")]
			[Address(RVA = "0x233D9EC", Offset = "0x233D9EC", VA = "0x7BBCB3D9EC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600A933 RID: 43315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A933")]
		[Address(RVA = "0x233DA5C", Offset = "0x233DA5C", VA = "0x7BBCB3DA5C")]
		public List<tcp.RoomBasicInfo> GetRoomListByType(tcp.ERoom.TabType roomType)
		{
			return null;
		}

		// Token: 0x0600A934 RID: 43316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A934")]
		[Address(RVA = "0x233DB20", Offset = "0x233DB20", VA = "0x7BBCB3DB20")]
		public List<tcp.RoomBasicInfo> GenerateRoomBasicInfoFromBatchRoom()
		{
			return null;
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600A935 RID: 43317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B15")]
		public tcp.RoomInfo CurrentRoomInfo
		{
			[Token(Token = "0x600A935")]
			[Address(RVA = "0x233E36C", Offset = "0x233E36C", VA = "0x7BBCB3E36C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x0600A936 RID: 43318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B16")]
		public RoomPlayerInfo MyPlayerInfo
		{
			[Token(Token = "0x600A936")]
			[Address(RVA = "0x233E374", Offset = "0x233E374", VA = "0x7BBCB3E374")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x0600A937 RID: 43319 RVA: 0x0002DC78 File Offset: 0x0002BE78
		[Token(Token = "0x17000B17")]
		public uint CurrentGroupMode
		{
			[Token(Token = "0x600A937")]
			[Address(RVA = "0x233E37C", Offset = "0x233E37C", VA = "0x7BBCB3E37C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x0600A938 RID: 43320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B18")]
		public List<RoomPlayerInfo> CurrentSpectators
		{
			[Token(Token = "0x600A938")]
			[Address(RVA = "0x233E3AC", Offset = "0x233E3AC", VA = "0x7BBCB3E3AC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x0600A939 RID: 43321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B19")]
		public List<RoomGroupInfo> CurrentGroups
		{
			[Token(Token = "0x600A939")]
			[Address(RVA = "0x233E438", Offset = "0x233E438", VA = "0x7BBCB3E438")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A93A RID: 43322 RVA: 0x0002DC90 File Offset: 0x0002BE90
		[Token(Token = "0x600A93A")]
		[Address(RVA = "0x233E4A0", Offset = "0x233E4A0", VA = "0x7BBCB3E4A0")]
		public uint GetGroupIcon()
		{
			return 0U;
		}

		// Token: 0x0600A93B RID: 43323 RVA: 0x0002DCA8 File Offset: 0x0002BEA8
		[Token(Token = "0x600A93B")]
		[Address(RVA = "0x233E534", Offset = "0x233E534", VA = "0x7BBCB3E534")]
		public ulong GetMyGroupID()
		{
			return 0UL;
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x0600A93C RID: 43324 RVA: 0x0002DCC0 File Offset: 0x0002BEC0
		[Token(Token = "0x17000B1A")]
		public int CurrentRealGroupCount
		{
			[Token(Token = "0x600A93C")]
			[Address(RVA = "0x233E548", Offset = "0x233E548", VA = "0x7BBCB3E548")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x0600A93D RID: 43325 RVA: 0x0002DCD8 File Offset: 0x0002BED8
		[Token(Token = "0x17000B1B")]
		public int CurrentPlayerCount
		{
			[Token(Token = "0x600A93D")]
			[Address(RVA = "0x233E698", Offset = "0x233E698", VA = "0x7BBCB3E698")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600A93E RID: 43326 RVA: 0x0002DCF0 File Offset: 0x0002BEF0
		[Token(Token = "0x600A93E")]
		[Address(RVA = "0x233E074", Offset = "0x233E074", VA = "0x7BBCB3E074")]
		public uint CalPlayerCount(tcp.RoomInfo info)
		{
			return 0U;
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x0600A93F RID: 43327 RVA: 0x0002DD08 File Offset: 0x0002BF08
		[Token(Token = "0x17000B1C")]
		public int CurrentSpectatorCount
		{
			[Token(Token = "0x600A93F")]
			[Address(RVA = "0x233E99C", Offset = "0x233E99C", VA = "0x7BBCB3E99C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x0600A940 RID: 43328 RVA: 0x0002DD20 File Offset: 0x0002BF20
		[Token(Token = "0x17000B1D")]
		public int CurrentGroupCount
		{
			[Token(Token = "0x600A940")]
			[Address(RVA = "0x233EA14", Offset = "0x233EA14", VA = "0x7BBCB3EA14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600A941 RID: 43329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A941")]
		[Address(RVA = "0x233EAB8", Offset = "0x233EAB8", VA = "0x7BBCB3EAB8")]
		public void RequestRoomList(tcp.ERoom.TabType tabType, ulong id = 0UL, [Optional] List<EMatch.GameMode> gameModes)
		{
		}

		// Token: 0x0600A942 RID: 43330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A942")]
		[Address(RVA = "0x233ED64", Offset = "0x233ED64", VA = "0x7BBCB3ED64")]
		public void RequestCreateRoom(RoomParams param)
		{
		}

		// Token: 0x0600A943 RID: 43331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A943")]
		[Address(RVA = "0x233FCEC", Offset = "0x233FCEC", VA = "0x7BBCB3FCEC")]
		public void RequestChangeRoom(RoomParams param)
		{
		}

		// Token: 0x0600A944 RID: 43332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A944")]
		[Address(RVA = "0x2340078", Offset = "0x2340078", VA = "0x7BBCB40078")]
		public void RequestJoinRoom(ulong id, string code = "", string name = "", string nameAbbr = "", bool solo = false, bool skipTickCheck = false, ulong inviterid = 0UL, uint roomType = 0U)
		{
		}

		// Token: 0x0600A945 RID: 43333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A945")]
		[Address(RVA = "0x23406CC", Offset = "0x23406CC", VA = "0x7BBCB406CC")]
		public void InvitationRequestJoinRoom(ulong id, bool skipTickCheck, ulong inviterid, uint map, uint mode, uint roomtype)
		{
		}

		// Token: 0x0600A946 RID: 43334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A946")]
		[Address(RVA = "0x2340A54", Offset = "0x2340A54", VA = "0x7BBCB40A54")]
		public void RequestSpectateRoom(ulong id, string code = "", bool solo = false, uint roomType = 0U)
		{
		}

		// Token: 0x0600A947 RID: 43335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A947")]
		[Address(RVA = "0x2340FB4", Offset = "0x2340FB4", VA = "0x7BBCB40FB4")]
		public void RequestRoomInfo(ulong id, tcp.ERoom.Type roomType)
		{
		}

		// Token: 0x0600A948 RID: 43336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A948")]
		[Address(RVA = "0x23410EC", Offset = "0x23410EC", VA = "0x7BBCB410EC")]
		public void RequestLeaveRoom()
		{
		}

		// Token: 0x0600A949 RID: 43337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A949")]
		[Address(RVA = "0x2341368", Offset = "0x2341368", VA = "0x7BBCB41368")]
		public void RequestBatchLeaveRoom(ulong id)
		{
		}

		// Token: 0x0600A94A RID: 43338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A94A")]
		[Address(RVA = "0x23416B8", Offset = "0x23416B8", VA = "0x7BBCB416B8")]
		public void RequestStartGame(ulong id)
		{
		}

		// Token: 0x0600A94B RID: 43339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A94B")]
		[Address(RVA = "0x23417B8", Offset = "0x23417B8", VA = "0x7BBCB417B8")]
		public void RequsetCountDown(ulong id)
		{
		}

		// Token: 0x0600A94C RID: 43340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A94C")]
		[Address(RVA = "0x2341900", Offset = "0x2341900", VA = "0x7BBCB41900")]
		public void RequestDropMatch()
		{
		}

		// Token: 0x0600A94D RID: 43341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A94D")]
		[Address(RVA = "0x23419C4", Offset = "0x23419C4", VA = "0x7BBCB419C4")]
		public void RequestSetReady(bool ready)
		{
		}

		// Token: 0x0600A94E RID: 43342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A94E")]
		[Address(RVA = "0x2341AF0", Offset = "0x2341AF0", VA = "0x7BBCB41AF0")]
		public void RequestSwitchSeat(ulong account_id, tcp.ERoom.PlayerRole role = tcp.ERoom.PlayerRole.PlayerRole_MEMBER, uint teamIndex = 0U, uint memberIndex = 0U)
		{
		}

		// Token: 0x0600A94F RID: 43343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A94F")]
		[Address(RVA = "0x2341D18", Offset = "0x2341D18", VA = "0x7BBCB41D18")]
		public void RequestSwitchGroup(int from, int to)
		{
		}

		// Token: 0x0600A950 RID: 43344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A950")]
		[Address(RVA = "0x2341FCC", Offset = "0x2341FCC", VA = "0x7BBCB41FCC")]
		public void RequestInvite(ulong account_id)
		{
		}

		// Token: 0x0600A951 RID: 43345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A951")]
		[Address(RVA = "0x23420CC", Offset = "0x23420CC", VA = "0x7BBCB420CC")]
		public void RequestUpdateMaps(List<uint> maps)
		{
		}

		// Token: 0x0600A952 RID: 43346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A952")]
		[Address(RVA = "0x2342274", Offset = "0x2342274", VA = "0x7BBCB42274")]
		public void RequestRoomCreateRules()
		{
		}

		// Token: 0x0600A953 RID: 43347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A953")]
		[Address(RVA = "0x23423D8", Offset = "0x23423D8", VA = "0x7BBCB423D8")]
		public void RequestKickPlayer(ulong id)
		{
		}

		// Token: 0x0600A954 RID: 43348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A954")]
		[Address(RVA = "0x2341240", Offset = "0x2341240", VA = "0x7BBCB41240")]
		public void ClearData(string ctx)
		{
		}

		// Token: 0x0600A955 RID: 43349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A955")]
		[Address(RVA = "0x2342514", Offset = "0x2342514", VA = "0x7BBCB42514")]
		public void UpdateRoomList(RoomListRes infos)
		{
		}

		// Token: 0x0600A956 RID: 43350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A956")]
		[Address(RVA = "0x2342800", Offset = "0x2342800", VA = "0x7BBCB42800")]
		public void ClearRoomList()
		{
		}

		// Token: 0x0600A957 RID: 43351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A957")]
		[Address(RVA = "0x2342860", Offset = "0x2342860", VA = "0x7BBCB42860")]
		private void UpdateRoomInfo(tcp.RoomInfo info)
		{
		}

		// Token: 0x0600A958 RID: 43352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A958")]
		[Address(RVA = "0x2343788", Offset = "0x2343788", VA = "0x7BBCB43788")]
		public void UpdateCreateRoomInfo(tcp.RoomInfo info)
		{
		}

		// Token: 0x0600A959 RID: 43353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A959")]
		[Address(RVA = "0x234396C", Offset = "0x234396C", VA = "0x7BBCB4396C")]
		public void BatchJoinRoom(ulong id)
		{
		}

		// Token: 0x0600A95A RID: 43354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A95A")]
		[Address(RVA = "0x2343C0C", Offset = "0x2343C0C", VA = "0x7BBCB43C0C")]
		public void UpdateCurrentRoomInfo(tcp.RoomInfo info, bool checkSeat = false)
		{
		}

		// Token: 0x0600A95B RID: 43355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A95B")]
		[Address(RVA = "0x2343F0C", Offset = "0x2343F0C", VA = "0x7BBCB43F0C")]
		public void UpdateCurrentReadyState(tcp.RoomInfo roomInfo, List<RoomPlayerInfo> players, bool needNotify)
		{
		}

		// Token: 0x0600A95C RID: 43356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A95C")]
		[Address(RVA = "0x234434C", Offset = "0x234434C", VA = "0x7BBCB4434C")]
		public void UpdateRoomState(tcp.RoomInfo roomInfo, RoomStateNtf state, bool needNotify)
		{
		}

		// Token: 0x0600A95D RID: 43357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A95D")]
		[Address(RVA = "0x23444C0", Offset = "0x23444C0", VA = "0x7BBCB444C0")]
		public void UpdateRoomPlayerAvailableMaps(tcp.RoomInfo roomInfo, RoomChangeAvailableMapsNtf info, bool needNotify)
		{
		}

		// Token: 0x0600A95E RID: 43358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A95E")]
		[Address(RVA = "0x2344940", Offset = "0x2344940", VA = "0x7BBCB44940")]
		public void UpdateRoom()
		{
		}

		// Token: 0x0600A95F RID: 43359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A95F")]
		[Address(RVA = "0x234293C", Offset = "0x234293C", VA = "0x7BBCB4293C")]
		private RoomPlayerInfo FindMyPlayerInfoFromRoomInfo()
		{
			return null;
		}

		// Token: 0x0600A960 RID: 43360 RVA: 0x0002DD38 File Offset: 0x0002BF38
		[Token(Token = "0x600A960")]
		[Address(RVA = "0x2344A2C", Offset = "0x2344A2C", VA = "0x7BBCB44A2C")]
		public bool IsValidSpectator()
		{
			return default(bool);
		}

		// Token: 0x0600A961 RID: 43361 RVA: 0x0002DD50 File Offset: 0x0002BF50
		[Token(Token = "0x600A961")]
		[Address(RVA = "0x2344B3C", Offset = "0x2344B3C", VA = "0x7BBCB44B3C")]
		public bool IsValidLeaguePlayer(uint groupMode)
		{
			return default(bool);
		}

		// Token: 0x0600A962 RID: 43362 RVA: 0x0002DD68 File Offset: 0x0002BF68
		[Token(Token = "0x600A962")]
		[Address(RVA = "0x2344E20", Offset = "0x2344E20", VA = "0x7BBCB44E20")]
		public bool IsValidCasualPlayer()
		{
			return default(bool);
		}

		// Token: 0x0600A963 RID: 43363 RVA: 0x0002DD80 File Offset: 0x0002BF80
		[Token(Token = "0x600A963")]
		[Address(RVA = "0x2344E88", Offset = "0x2344E88", VA = "0x7BBCB44E88")]
		public bool CheckIsValidUser()
		{
			return default(bool);
		}

		// Token: 0x0600A964 RID: 43364 RVA: 0x0002DD98 File Offset: 0x0002BF98
		[Token(Token = "0x600A964")]
		[Address(RVA = "0x23453C0", Offset = "0x23453C0", VA = "0x7BBCB453C0")]
		public bool IsRoomMaster()
		{
			return default(bool);
		}

		// Token: 0x0600A965 RID: 43365 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
		[Token(Token = "0x600A965")]
		[Address(RVA = "0x2345468", Offset = "0x2345468", VA = "0x7BBCB45468")]
		public bool IsRoomPartner()
		{
			return default(bool);
		}

		// Token: 0x0600A966 RID: 43366 RVA: 0x0002DDC8 File Offset: 0x0002BFC8
		[Token(Token = "0x600A966")]
		[Address(RVA = "0x2345510", Offset = "0x2345510", VA = "0x7BBCB45510")]
		public bool IsValidPCUser()
		{
			return default(bool);
		}

		// Token: 0x0600A967 RID: 43367 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		[Token(Token = "0x600A967")]
		[Address(RVA = "0x2345534", Offset = "0x2345534", VA = "0x7BBCB45534")]
		public bool CheckEmptySeat(out uint teamIndex, out uint memberIndex)
		{
			return default(bool);
		}

		// Token: 0x0600A968 RID: 43368 RVA: 0x0002DDF8 File Offset: 0x0002BFF8
		[Token(Token = "0x600A968")]
		[Address(RVA = "0x23456E8", Offset = "0x23456E8", VA = "0x7BBCB456E8")]
		public bool IsNeedLeave(RoomPlayerInfo player, tcp.RoomInfo room)
		{
			return default(bool);
		}

		// Token: 0x0600A969 RID: 43369 RVA: 0x0002DE10 File Offset: 0x0002C010
		[Token(Token = "0x600A969")]
		[Address(RVA = "0x23457BC", Offset = "0x23457BC", VA = "0x7BBCB457BC")]
		public bool IsSelf(ulong id)
		{
			return default(bool);
		}

		// Token: 0x0600A96A RID: 43370 RVA: 0x0002DE28 File Offset: 0x0002C028
		[Token(Token = "0x600A96A")]
		[Address(RVA = "0x234586C", Offset = "0x234586C", VA = "0x7BBCB4586C")]
		public bool IsCreater()
		{
			return default(bool);
		}

		// Token: 0x0600A96B RID: 43371 RVA: 0x0002DE40 File Offset: 0x0002C040
		[Token(Token = "0x600A96B")]
		[Address(RVA = "0x234587C", Offset = "0x234587C", VA = "0x7BBCB4587C")]
		public bool IsPlayer()
		{
			return default(bool);
		}

		// Token: 0x0600A96C RID: 43372 RVA: 0x0002DE58 File Offset: 0x0002C058
		[Token(Token = "0x600A96C")]
		[Address(RVA = "0x234588C", Offset = "0x234588C", VA = "0x7BBCB4588C")]
		public bool IsSpectator()
		{
			return default(bool);
		}

		// Token: 0x0600A96D RID: 43373 RVA: 0x0002DE70 File Offset: 0x0002C070
		[Token(Token = "0x600A96D")]
		[Address(RVA = "0x234589C", Offset = "0x234589C", VA = "0x7BBCB4589C")]
		public bool IsGroupLeader()
		{
			return default(bool);
		}

		// Token: 0x0600A96E RID: 43374 RVA: 0x0002DE88 File Offset: 0x0002C088
		[Token(Token = "0x600A96E")]
		[Address(RVA = "0x2345970", Offset = "0x2345970", VA = "0x7BBCB45970")]
		public bool NeedShowReadyBtn()
		{
			return default(bool);
		}

		// Token: 0x0600A96F RID: 43375 RVA: 0x0002DEA0 File Offset: 0x0002C0A0
		[Token(Token = "0x600A96F")]
		[Address(RVA = "0x2345A18", Offset = "0x2345A18", VA = "0x7BBCB45A18")]
		public bool IsReadyBtnEnabled()
		{
			return default(bool);
		}

		// Token: 0x0600A970 RID: 43376 RVA: 0x0002DEB8 File Offset: 0x0002C0B8
		[Token(Token = "0x600A970")]
		[Address(RVA = "0x2345A50", Offset = "0x2345A50", VA = "0x7BBCB45A50")]
		public bool CurrentReadyState()
		{
			return default(bool);
		}

		// Token: 0x0600A971 RID: 43377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A971")]
		[Address(RVA = "0x2345A64", Offset = "0x2345A64", VA = "0x7BBCB45A64")]
		public void OnCustomRoomDismissed(tcp.ERoom.DismissReason reason)
		{
		}

		// Token: 0x0600A972 RID: 43378 RVA: 0x0002DED0 File Offset: 0x0002C0D0
		[Token(Token = "0x600A972")]
		[Address(RVA = "0x2345FD0", Offset = "0x2345FD0", VA = "0x7BBCB45FD0")]
		public bool IsInRoom()
		{
			return default(bool);
		}

		// Token: 0x0600A973 RID: 43379 RVA: 0x0002DEE8 File Offset: 0x0002C0E8
		[Token(Token = "0x600A973")]
		[Address(RVA = "0x23459A8", Offset = "0x23459A8", VA = "0x7BBCB459A8")]
		public bool IsInLeagueRoom()
		{
			return default(bool);
		}

		// Token: 0x0600A974 RID: 43380 RVA: 0x0002DF00 File Offset: 0x0002C100
		[Token(Token = "0x600A974")]
		[Address(RVA = "0x2345FF0", Offset = "0x2345FF0", VA = "0x7BBCB45FF0")]
		public bool IsCasualRoom()
		{
			return default(bool);
		}

		// Token: 0x0600A975 RID: 43381 RVA: 0x0002DF18 File Offset: 0x0002C118
		[Token(Token = "0x600A975")]
		[Address(RVA = "0x234602C", Offset = "0x234602C", VA = "0x7BBCB4602C")]
		public bool IsLeagueRoom(tcp.ERoom.Type type)
		{
			return default(bool);
		}

		// Token: 0x0600A976 RID: 43382 RVA: 0x0002DF30 File Offset: 0x0002C130
		[Token(Token = "0x600A976")]
		[Address(RVA = "0x2346038", Offset = "0x2346038", VA = "0x7BBCB46038")]
		public bool IsInSpectatorSeat()
		{
			return default(bool);
		}

		// Token: 0x0600A977 RID: 43383 RVA: 0x0002DF48 File Offset: 0x0002C148
		[Token(Token = "0x600A977")]
		[Address(RVA = "0x2346214", Offset = "0x2346214", VA = "0x7BBCB46214")]
		public bool CheckIsValidSpectatorNumSetting(uint num)
		{
			return default(bool);
		}

		// Token: 0x0600A978 RID: 43384 RVA: 0x0002DF60 File Offset: 0x0002C160
		[Token(Token = "0x600A978")]
		[Address(RVA = "0x2346240", Offset = "0x2346240", VA = "0x7BBCB46240")]
		public ulong GetNotReadyMemberId()
		{
			return 0UL;
		}

		// Token: 0x0600A979 RID: 43385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A979")]
		[Address(RVA = "0x23466E4", Offset = "0x23466E4", VA = "0x7BBCB466E4")]
		public string GetNameById(ulong id)
		{
			return null;
		}

		// Token: 0x0600A97A RID: 43386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A97A")]
		[Address(RVA = "0x2346B2C", Offset = "0x2346B2C", VA = "0x7BBCB46B2C")]
		public RoomPlayerInfo GetCurRoomPlayerInfoById(ulong id)
		{
			return null;
		}

		// Token: 0x0600A97B RID: 43387 RVA: 0x0002DF78 File Offset: 0x0002C178
		[Token(Token = "0x600A97B")]
		[Address(RVA = "0x2346F30", Offset = "0x2346F30", VA = "0x7BBCB46F30")]
		public bool CheckIsValidPlayerNumSetting(uint num)
		{
			return default(bool);
		}

		// Token: 0x0600A97C RID: 43388 RVA: 0x0002DF90 File Offset: 0x0002C190
		[Token(Token = "0x600A97C")]
		[Address(RVA = "0x2347024", Offset = "0x2347024", VA = "0x7BBCB47024")]
		public bool IsPlayerNumValid()
		{
			return default(bool);
		}

		// Token: 0x0600A97D RID: 43389 RVA: 0x0002DFA8 File Offset: 0x0002C1A8
		[Token(Token = "0x600A97D")]
		[Address(RVA = "0x23471E0", Offset = "0x23471E0", VA = "0x7BBCB471E0")]
		public uint GetValidPlayerNum()
		{
			return 0U;
		}

		// Token: 0x0600A97E RID: 43390 RVA: 0x0002DFC0 File Offset: 0x0002C1C0
		[Token(Token = "0x600A97E")]
		[Address(RVA = "0x2347380", Offset = "0x2347380", VA = "0x7BBCB47380")]
		public bool IsPlayerMapsAllAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600A97F RID: 43391 RVA: 0x0002DFD8 File Offset: 0x0002C1D8
		[Token(Token = "0x600A97F")]
		[Address(RVA = "0x23475B4", Offset = "0x23475B4", VA = "0x7BBCB475B4")]
		public bool IsObserverMapsAllAvailable()
		{
			return default(bool);
		}

		// Token: 0x0600A980 RID: 43392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A980")]
		[Address(RVA = "0x2347744", Offset = "0x2347744", VA = "0x7BBCB47744")]
		public void SetReopenId(ulong id)
		{
		}

		// Token: 0x0600A981 RID: 43393 RVA: 0x0002DFF0 File Offset: 0x0002C1F0
		[Token(Token = "0x600A981")]
		[Address(RVA = "0x234774C", Offset = "0x234774C", VA = "0x7BBCB4774C")]
		public ulong GetReopenId()
		{
			return 0UL;
		}

		// Token: 0x0600A982 RID: 43394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A982")]
		[Address(RVA = "0x2347754", Offset = "0x2347754", VA = "0x7BBCB47754")]
		public void ResetReopenId()
		{
		}

		// Token: 0x0600A983 RID: 43395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A983")]
		[Address(RVA = "0x234775C", Offset = "0x234775C", VA = "0x7BBCB4775C")]
		public void LogRoomId(ulong id)
		{
		}

		// Token: 0x0600A984 RID: 43396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A984")]
		[Address(RVA = "0x2347760", Offset = "0x2347760", VA = "0x7BBCB47760")]
		public void LogBatchMatchId(ulong id)
		{
		}

		// Token: 0x0600A985 RID: 43397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A985")]
		[Address(RVA = "0x2347764", Offset = "0x2347764", VA = "0x7BBCB47764")]
		public void SetSelected(int index)
		{
		}

		// Token: 0x0600A986 RID: 43398 RVA: 0x0002E008 File Offset: 0x0002C208
		[Token(Token = "0x600A986")]
		[Address(RVA = "0x234776C", Offset = "0x234776C", VA = "0x7BBCB4776C")]
		public int GetSelected()
		{
			return 0;
		}

		// Token: 0x0600A987 RID: 43399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A987")]
		[Address(RVA = "0x2347774", Offset = "0x2347774", VA = "0x7BBCB47774")]
		public void ClearSelected()
		{
		}

		// Token: 0x0600A988 RID: 43400 RVA: 0x0002E020 File Offset: 0x0002C220
		[Token(Token = "0x600A988")]
		[Address(RVA = "0x2347780", Offset = "0x2347780", VA = "0x7BBCB47780")]
		public bool HasSelected()
		{
			return default(bool);
		}

		// Token: 0x0600A989 RID: 43401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A989")]
		[Address(RVA = "0x2347790", Offset = "0x2347790", VA = "0x7BBCB47790")]
		public string GetGroupName(int index)
		{
			return null;
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x0002E038 File Offset: 0x0002C238
		[Token(Token = "0x600A98A")]
		[Address(RVA = "0x2347840", Offset = "0x2347840", VA = "0x7BBCB47840")]
		public bool IsEnableVoice()
		{
			return default(bool);
		}

		// Token: 0x0600A98B RID: 43403 RVA: 0x0002E050 File Offset: 0x0002C250
		[Token(Token = "0x600A98B")]
		[Address(RVA = "0x2347888", Offset = "0x2347888", VA = "0x7BBCB47888")]
		public bool IsInBatchRoom()
		{
			return default(bool);
		}

		// Token: 0x0600A98C RID: 43404 RVA: 0x0002E068 File Offset: 0x0002C268
		[Token(Token = "0x600A98C")]
		[Address(RVA = "0x23478F4", Offset = "0x23478F4", VA = "0x7BBCB478F4")]
		public bool IsInCurrentBatchRoom(ulong id)
		{
			return default(bool);
		}

		// Token: 0x0600A98D RID: 43405 RVA: 0x0002E080 File Offset: 0x0002C280
		[Token(Token = "0x600A98D")]
		[Address(RVA = "0x234793C", Offset = "0x234793C", VA = "0x7BBCB4793C")]
		public bool IsMyBatchRoom(ulong id)
		{
			return default(bool);
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A98E")]
		[Address(RVA = "0x2341484", Offset = "0x2341484", VA = "0x7BBCB41484")]
		public void ClearBatchData(ulong roomid, tcp.ERoom.DismissReason reason)
		{
		}

		// Token: 0x0600A98F RID: 43407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A98F")]
		[Address(RVA = "0x2347A28", Offset = "0x2347A28", VA = "0x7BBCB47A28")]
		public void UpdateBatchRoomInfo(tcp.RoomInfo roomInfo)
		{
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A990")]
		[Address(RVA = "0x2347C98", Offset = "0x2347C98", VA = "0x7BBCB47C98")]
		public void UpdateBatchRoomState(RoomStateNtf state)
		{
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A991")]
		[Address(RVA = "0x2347ECC", Offset = "0x2347ECC", VA = "0x7BBCB47ECC")]
		public void UpdateBatchRoomReadyState(ulong roomid, List<RoomPlayerInfo> players)
		{
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x0002E098 File Offset: 0x0002C298
		[Token(Token = "0x600A992")]
		[Address(RVA = "0x23480C8", Offset = "0x23480C8", VA = "0x7BBCB480C8")]
		public int GetBatchRoomCount()
		{
			return 0;
		}

		// Token: 0x0600A993 RID: 43411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A993")]
		[Address(RVA = "0x2348128", Offset = "0x2348128", VA = "0x7BBCB48128")]
		public void UpdateBatchRoomPlayerAvailableMaps(RoomChangeAvailableMapsNtf info)
		{
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x0600A994 RID: 43412 RVA: 0x0002E0B0 File Offset: 0x0002C2B0
		// (set) Token: 0x0600A995 RID: 43413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1E")]
		public bool ADCSEnabled
		{
			[Token(Token = "0x600A994")]
			[Address(RVA = "0x233F430", Offset = "0x233F430", VA = "0x7BBCB3F430")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145F7C", Offset = "0x1145F7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A995")]
			[Address(RVA = "0x2342D9C", Offset = "0x2342D9C", VA = "0x7BBCB42D9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145F8C", Offset = "0x1145F8C")]
			set
			{
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x0600A996 RID: 43414 RVA: 0x0002E0C8 File Offset: 0x0002C2C8
		// (set) Token: 0x0600A997 RID: 43415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1F")]
		public int AdCSEcoRound
		{
			[Token(Token = "0x600A996")]
			[Address(RVA = "0x234835C", Offset = "0x234835C", VA = "0x7BBCB4835C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145F9C", Offset = "0x1145F9C")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600A997")]
			[Address(RVA = "0x2348364", Offset = "0x2348364", VA = "0x7BBCB48364")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145FAC", Offset = "0x1145FAC")]
			set
			{
			}
		}

		// Token: 0x0600A998 RID: 43416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A998")]
		[Address(RVA = "0x233D17C", Offset = "0x233D17C", VA = "0x7BBCB3D17C")]
		public void InitDefaultCSSettingFromConfig()
		{
		}

		// Token: 0x0600A999 RID: 43417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A999")]
		[Address(RVA = "0x2342DA8", Offset = "0x2342DA8", VA = "0x7BBCB42DA8")]
		public void InitCSShopSettingFromBytes()
		{
		}

		// Token: 0x0600A99A RID: 43418 RVA: 0x0002E0E0 File Offset: 0x0002C2E0
		[Token(Token = "0x600A99A")]
		[Address(RVA = "0x234836C", Offset = "0x234836C", VA = "0x7BBCB4836C")]
		public int GetCSShopSettingValueByIndex(uint index)
		{
			return 0;
		}

		// Token: 0x0600A99B RID: 43419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A99B")]
		[Address(RVA = "0x23483DC", Offset = "0x23483DC", VA = "0x7BBCB483DC")]
		public void SetCSShopSettingValueByIndex(uint index, int val)
		{
		}

		// Token: 0x0600A99C RID: 43420 RVA: 0x0002E0F8 File Offset: 0x0002C2F8
		[Token(Token = "0x600A99C")]
		[Address(RVA = "0x2348454", Offset = "0x2348454", VA = "0x7BBCB48454")]
		public bool GetCSShopSettingCheckByIndex(uint index)
		{
			return default(bool);
		}

		// Token: 0x0600A99D RID: 43421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A99D")]
		[Address(RVA = "0x23484C4", Offset = "0x23484C4", VA = "0x7BBCB484C4")]
		public void SetCSShopSettingCheckByIndex(uint index, bool check)
		{
		}

		// Token: 0x0600A99E RID: 43422 RVA: 0x0002E110 File Offset: 0x0002C310
		[Token(Token = "0x600A99E")]
		[Address(RVA = "0x234853C", Offset = "0x234853C", VA = "0x7BBCB4853C")]
		public int GetCSRoundValueByIndex(int index)
		{
			return 0;
		}

		// Token: 0x0600A99F RID: 43423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A99F")]
		[Address(RVA = "0x23485AC", Offset = "0x23485AC", VA = "0x7BBCB485AC")]
		public void SetCSRoundValueByIndex(int index, int val)
		{
		}

		// Token: 0x0600A9A0 RID: 43424 RVA: 0x0002E128 File Offset: 0x0002C328
		[Token(Token = "0x600A9A0")]
		[Address(RVA = "0x2348624", Offset = "0x2348624", VA = "0x7BBCB48624")]
		public int GetSelectedShopItemCnt()
		{
			return 0;
		}

		// Token: 0x0600A9A1 RID: 43425 RVA: 0x0002E140 File Offset: 0x0002C340
		[Token(Token = "0x600A9A1")]
		[Address(RVA = "0x2348714", Offset = "0x2348714", VA = "0x7BBCB48714")]
		public static uint GenerateWereWolvesSettingBitFromMap(int settingNum, Dictionary<INp{ZCe, uint> paramMap)
		{
			return 0U;
		}

		// Token: 0x0600A9A2 RID: 43426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9A2")]
		[Address(RVA = "0x23487E4", Offset = "0x23487E4", VA = "0x7BBCB487E4")]
		public Dictionary<INp{ZCe, uint> GenerateWereWolvesSettingMapFromBit()
		{
			return null;
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x0600A9A3 RID: 43427 RVA: 0x0002E158 File Offset: 0x0002C358
		[Token(Token = "0x17000B20")]
		public ESocial.Language WereWolvesRoomLanguage
		{
			[Token(Token = "0x600A9A3")]
			[Address(RVA = "0x2348934", Offset = "0x2348934", VA = "0x7BBCB48934")]
			get
			{
				return ESocial.Language.Language_NONE;
			}
		}

		// Token: 0x0600A9A4 RID: 43428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9A4")]
		[Address(RVA = "0x233F438", Offset = "0x233F438", VA = "0x7BBCB3F438")]
		private byte[] GenerateADCSSettingBytes()
		{
			return null;
		}

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9A5")]
		[Address(RVA = "0x2348948", Offset = "0x2348948", VA = "0x7BBCB48948")]
		public UIModelCustomRoom()
		{
		}

		// Token: 0x0400AEB1 RID: 44721
		[Token(Token = "0x400AEB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FF0C", Offset = "0x112FF0C")]
		private ECustomRoomRole <MyRoomRole>k__BackingField;

		// Token: 0x0400AEB2 RID: 44722
		[Token(Token = "0x400AEB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private tcp.RoomInfo m_CurrentRoomInfo;

		// Token: 0x0400AEB3 RID: 44723
		[Token(Token = "0x400AEB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RoomPlayerInfo m_MyPlayerInfo;

		// Token: 0x0400AEB4 RID: 44724
		[Token(Token = "0x400AEB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RoomGroupInfo m_MyGroupInfo;

		// Token: 0x0400AEB5 RID: 44725
		[Token(Token = "0x400AEB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_ShowNickName;

		// Token: 0x0400AEB6 RID: 44726
		[Token(Token = "0x400AEB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Dictionary<proto.EInventory.ItemSubType, uint> CardTypeItemIdDic;

		// Token: 0x0400AEB7 RID: 44727
		[Token(Token = "0x400AEB7")]
		public const uint PropID_RoomListUpdated = 2U;

		// Token: 0x0400AEB8 RID: 44728
		[Token(Token = "0x400AEB8")]
		public const uint PropID_RoomInfoUpdated = 4U;

		// Token: 0x0400AEB9 RID: 44729
		[Token(Token = "0x400AEB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UIModelGroup m_ModelGroup;

		// Token: 0x0400AEBA RID: 44730
		[Token(Token = "0x400AEBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<tcp.ERoom.TabType, List<tcp.RoomBasicInfo>> m_RoomListDict;

		// Token: 0x0400AEBB RID: 44731
		[Token(Token = "0x400AEBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MemoryStream m_MemStream;

		// Token: 0x0400AEBC RID: 44732
		[Token(Token = "0x400AEBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BinaryWriter m_Writer;

		// Token: 0x0400AEBD RID: 44733
		[Token(Token = "0x400AEBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BinaryReader m_Reader;

		// Token: 0x0400AEBE RID: 44734
		[Token(Token = "0x400AEBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ulong m_LatestTryConnectMatchId;

		// Token: 0x0400AEBF RID: 44735
		[Token(Token = "0x400AEBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ulong m_ReopenId;

		// Token: 0x0400AEC0 RID: 44736
		[Token(Token = "0x400AEC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int m_SelectedPos;

		// Token: 0x0400AEC1 RID: 44737
		[Token(Token = "0x400AEC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<tcp.RoomInfo> m_BatchRoomInfoList;

		// Token: 0x0400AEC2 RID: 44738
		[Token(Token = "0x400AEC2")]
		private const int ADCS_MIN_ROUND = 7;

		// Token: 0x0400AEC3 RID: 44739
		[Token(Token = "0x400AEC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<uint, int> m_AdCSShopSettingValueDic;

		// Token: 0x0400AEC4 RID: 44740
		[Token(Token = "0x400AEC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<uint, bool> m_AdCSShopSettingCheckDic;

		// Token: 0x0400AEC5 RID: 44741
		[Token(Token = "0x400AEC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<int, int> m_AdCSEcoRoundValueDic;

		// Token: 0x0400AEC6 RID: 44742
		[Token(Token = "0x400AEC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FF1C", Offset = "0x112FF1C")]
		private bool <ADCSEnabled>k__BackingField;

		// Token: 0x0400AEC7 RID: 44743
		[Token(Token = "0x400AEC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FF2C", Offset = "0x112FF2C")]
		private int <AdCSEcoRound>k__BackingField;

		// Token: 0x0400AEC8 RID: 44744
		[Token(Token = "0x400AEC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly uint WereWolvesMapConfigID;

		// Token: 0x0400AEC9 RID: 44745
		[Token(Token = "0x400AEC9")]
		private const int WereWolvesParamBitStep = 8;

		// Token: 0x02001E3E RID: 7742
		[Token(Token = "0x2001E3E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC514", Offset = "0x10FC514")]
		private sealed class <>c__DisplayClass76_0
		{
			// Token: 0x0600A9A7 RID: 43431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A9A7")]
			[Address(RVA = "0x2343C04", Offset = "0x2343C04", VA = "0x7BBCB43C04")]
			public <>c__DisplayClass76_0()
			{
			}

			// Token: 0x0600A9A8 RID: 43432 RVA: 0x0002E170 File Offset: 0x0002C370
			[Token(Token = "0x600A9A8")]
			[Address(RVA = "0x2348E58", Offset = "0x2348E58", VA = "0x7BBCB48E58")]
			internal bool <BatchJoinRoom>b__0(tcp.RoomInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400AECA RID: 44746
			[Token(Token = "0x400AECA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong id;
		}

		// Token: 0x02001E3F RID: 7743
		[Token(Token = "0x2001E3F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC524", Offset = "0x10FC524")]
		private sealed class <>c__DisplayClass78_0
		{
			// Token: 0x0600A9A9 RID: 43433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A9A9")]
			[Address(RVA = "0x2344344", Offset = "0x2344344", VA = "0x7BBCB44344")]
			public <>c__DisplayClass78_0()
			{
			}

			// Token: 0x0600A9AA RID: 43434 RVA: 0x0002E188 File Offset: 0x0002C388
			[Token(Token = "0x600A9AA")]
			[Address(RVA = "0x2348E9C", Offset = "0x2348E9C", VA = "0x7BBCB48E9C")]
			internal bool <UpdateCurrentReadyState>b__0(RoomPlayerInfo p)
			{
				return default(bool);
			}

			// Token: 0x0600A9AB RID: 43435 RVA: 0x0002E1A0 File Offset: 0x0002C3A0
			[Token(Token = "0x600A9AB")]
			[Address(RVA = "0x2348EFC", Offset = "0x2348EFC", VA = "0x7BBCB48EFC")]
			internal bool <UpdateCurrentReadyState>b__1(RoomGroupInfo g)
			{
				return default(bool);
			}

			// Token: 0x0600A9AC RID: 43436 RVA: 0x0002E1B8 File Offset: 0x0002C3B8
			[Token(Token = "0x600A9AC")]
			[Address(RVA = "0x2348F5C", Offset = "0x2348F5C", VA = "0x7BBCB48F5C")]
			internal bool <UpdateCurrentReadyState>b__2(RoomPlayerInfo p)
			{
				return default(bool);
			}

			// Token: 0x0400AECB RID: 44747
			[Token(Token = "0x400AECB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoomPlayerInfo player;
		}

		// Token: 0x02001E40 RID: 7744
		[Token(Token = "0x2001E40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC534", Offset = "0x10FC534")]
		private sealed class <>c__DisplayClass131_0
		{
			// Token: 0x0600A9AD RID: 43437 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A9AD")]
			[Address(RVA = "0x2347A18", Offset = "0x2347A18", VA = "0x7BBCB47A18")]
			public <>c__DisplayClass131_0()
			{
			}

			// Token: 0x0600A9AE RID: 43438 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
			[Token(Token = "0x600A9AE")]
			[Address(RVA = "0x2348C6C", Offset = "0x2348C6C", VA = "0x7BBCB48C6C")]
			internal bool <IsMyBatchRoom>b__0(tcp.RoomInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400AECC RID: 44748
			[Token(Token = "0x400AECC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong id;
		}

		// Token: 0x02001E41 RID: 7745
		[Token(Token = "0x2001E41")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC544", Offset = "0x10FC544")]
		private sealed class <>c__DisplayClass132_0
		{
			// Token: 0x0600A9AF RID: 43439 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A9AF")]
			[Address(RVA = "0x2347A20", Offset = "0x2347A20", VA = "0x7BBCB47A20")]
			public <>c__DisplayClass132_0()
			{
			}

			// Token: 0x0600A9B0 RID: 43440 RVA: 0x0002E1E8 File Offset: 0x0002C3E8
			[Token(Token = "0x600A9B0")]
			[Address(RVA = "0x2348CB0", Offset = "0x2348CB0", VA = "0x7BBCB48CB0")]
			internal bool <ClearBatchData>b__0(tcp.RoomInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400AECD RID: 44749
			[Token(Token = "0x400AECD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong roomid;
		}

		// Token: 0x02001E42 RID: 7746
		[Token(Token = "0x2001E42")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC554", Offset = "0x10FC554")]
		private sealed class <>c__DisplayClass133_0
		{
			// Token: 0x0600A9B1 RID: 43441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A9B1")]
			[Address(RVA = "0x2347C90", Offset = "0x2347C90", VA = "0x7BBCB47C90")]
			public <>c__DisplayClass133_0()
			{
			}

			// Token: 0x0600A9B2 RID: 43442 RVA: 0x0002E200 File Offset: 0x0002C400
			[Token(Token = "0x600A9B2")]
			[Address(RVA = "0x2348CF4", Offset = "0x2348CF4", VA = "0x7BBCB48CF4")]
			internal bool <UpdateBatchRoomInfo>b__0(tcp.RoomInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400AECE RID: 44750
			[Token(Token = "0x400AECE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public tcp.RoomInfo roomInfo;
		}

		// Token: 0x02001E43 RID: 7747
		[Token(Token = "0x2001E43")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC564", Offset = "0x10FC564")]
		private sealed class <>c__DisplayClass134_0
		{
			// Token: 0x0600A9B3 RID: 43443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A9B3")]
			[Address(RVA = "0x2347EC4", Offset = "0x2347EC4", VA = "0x7BBCB47EC4")]
			public <>c__DisplayClass134_0()
			{
			}

			// Token: 0x0600A9B4 RID: 43444 RVA: 0x0002E218 File Offset: 0x0002C418
			[Token(Token = "0x600A9B4")]
			[Address(RVA = "0x2348D54", Offset = "0x2348D54", VA = "0x7BBCB48D54")]
			internal bool <UpdateBatchRoomState>b__0(tcp.RoomInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400AECF RID: 44751
			[Token(Token = "0x400AECF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoomStateNtf state;
		}

		// Token: 0x02001E44 RID: 7748
		[Token(Token = "0x2001E44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC574", Offset = "0x10FC574")]
		private sealed class <>c__DisplayClass135_0
		{
			// Token: 0x0600A9B5 RID: 43445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A9B5")]
			[Address(RVA = "0x23480C0", Offset = "0x23480C0", VA = "0x7BBCB480C0")]
			public <>c__DisplayClass135_0()
			{
			}

			// Token: 0x0600A9B6 RID: 43446 RVA: 0x0002E230 File Offset: 0x0002C430
			[Token(Token = "0x600A9B6")]
			[Address(RVA = "0x2348DB4", Offset = "0x2348DB4", VA = "0x7BBCB48DB4")]
			internal bool <UpdateBatchRoomReadyState>b__0(tcp.RoomInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400AED0 RID: 44752
			[Token(Token = "0x400AED0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ulong roomid;
		}

		// Token: 0x02001E45 RID: 7749
		[Token(Token = "0x2001E45")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC584", Offset = "0x10FC584")]
		private sealed class <>c__DisplayClass137_0
		{
			// Token: 0x0600A9B7 RID: 43447 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A9B7")]
			[Address(RVA = "0x2348354", Offset = "0x2348354", VA = "0x7BBCB48354")]
			public <>c__DisplayClass137_0()
			{
			}

			// Token: 0x0600A9B8 RID: 43448 RVA: 0x0002E248 File Offset: 0x0002C448
			[Token(Token = "0x600A9B8")]
			[Address(RVA = "0x2348DF8", Offset = "0x2348DF8", VA = "0x7BBCB48DF8")]
			internal bool <UpdateBatchRoomPlayerAvailableMaps>b__0(tcp.RoomInfo e)
			{
				return default(bool);
			}

			// Token: 0x0400AED1 RID: 44753
			[Token(Token = "0x400AED1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RoomChangeAvailableMapsNtf info;
		}

		// Token: 0x02001E46 RID: 7750
		[Token(Token = "0x2001E46")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC594", Offset = "0x10FC594")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A9BA RID: 43450 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A9BA")]
			[Address(RVA = "0x2348BF4", Offset = "0x2348BF4", VA = "0x7BBCB48BF4")]
			public <>c()
			{
			}

			// Token: 0x0600A9BB RID: 43451 RVA: 0x0002E260 File Offset: 0x0002C460
			[Token(Token = "0x600A9BB")]
			[Address(RVA = "0x2348BFC", Offset = "0x2348BFC", VA = "0x7BBCB48BFC")]
			internal int <InitDefaultCSSettingFromConfig>b__150_0(string s)
			{
				return 0;
			}

			// Token: 0x0600A9BC RID: 43452 RVA: 0x0002E278 File Offset: 0x0002C478
			[Token(Token = "0x600A9BC")]
			[Address(RVA = "0x2348C08", Offset = "0x2348C08", VA = "0x7BBCB48C08")]
			internal int <InitCSShopSettingFromBytes>b__151_0(string s)
			{
				return 0;
			}

			// Token: 0x0600A9BD RID: 43453 RVA: 0x0002E290 File Offset: 0x0002C490
			[Token(Token = "0x600A9BD")]
			[Address(RVA = "0x2348C14", Offset = "0x2348C14", VA = "0x7BBCB48C14")]
			internal bool <GetSelectedShopItemCnt>b__158_0(KeyValuePair<uint, bool> e)
			{
				return default(bool);
			}

			// Token: 0x0400AED2 RID: 44754
			[Token(Token = "0x400AED2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIModelCustomRoom.<>c <>9;

			// Token: 0x0400AED3 RID: 44755
			[Token(Token = "0x400AED3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Converter<string, int> <>9__150_0;

			// Token: 0x0400AED4 RID: 44756
			[Token(Token = "0x400AED4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Converter<string, int> <>9__151_0;

			// Token: 0x0400AED5 RID: 44757
			[Token(Token = "0x400AED5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<KeyValuePair<uint, bool>, bool> <>9__158_0;
		}
	}
}
