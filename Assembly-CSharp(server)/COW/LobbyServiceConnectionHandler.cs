using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x020012DA RID: 4826
	[Token(Token = "0x20012DA")]
	internal class LobbyServiceConnectionHandler : ServiceConnectionHandler
	{
		// Token: 0x06004C0F RID: 19471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C0F")]
		[Address(RVA = "0x1408AD0", Offset = "0x1408AD0", VA = "0x7BBBC08AD0")]
		public LobbyServiceConnectionHandler(string token)
		{
		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x00016CC8 File Offset: 0x00014EC8
		[Token(Token = "0x6004C10")]
		[Address(RVA = "0x14090E8", Offset = "0x14090E8", VA = "0x7BBBC090E8", Slot = "11")]
		public override EServiceHandler GetServiceHandlerName()
		{
			return EServiceHandler.None;
		}

		// Token: 0x06004C11 RID: 19473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C11")]
		[Address(RVA = "0x14090F0", Offset = "0x14090F0", VA = "0x7BBBC090F0", Slot = "9")]
		public override void OnDisconnected(DisconnectedReason reason)
		{
		}

		// Token: 0x06004C12 RID: 19474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C12")]
		[Address(RVA = "0x1409418", Offset = "0x1409418", VA = "0x7BBBC09418")]
		private void OnMsgActivity(MessageNotify res)
		{
		}

		// Token: 0x06004C13 RID: 19475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C13")]
		[Address(RVA = "0x14096FC", Offset = "0x14096FC", VA = "0x7BBBC096FC")]
		private void OnMsgAvatarProfile(MessageNotify res)
		{
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x1409BA8", Offset = "0x1409BA8", VA = "0x7BBBC09BA8")]
		private void OnMsgChampionship(MessageNotify res)
		{
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C15")]
		[Address(RVA = "0x140A210", Offset = "0x140A210", VA = "0x7BBBC0A210")]
		private void OnMsgClan(MessageNotify res)
		{
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C16")]
		[Address(RVA = "0x140AD24", Offset = "0x140AD24", VA = "0x7BBBC0AD24")]
		private void OnMsgCustomRoom(MessageNotify res)
		{
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x00016CE0 File Offset: 0x00014EE0
		[Token(Token = "0x6004C17")]
		[Address(RVA = "0x140E6D0", Offset = "0x140E6D0", VA = "0x7BBBC0E6D0")]
		private bool CheckIsInBatchRoom()
		{
			return default(bool);
		}

		// Token: 0x06004C18 RID: 19480 RVA: 0x00016CF8 File Offset: 0x00014EF8
		[Token(Token = "0x6004C18")]
		[Address(RVA = "0x140E6D8", Offset = "0x140E6D8", VA = "0x7BBBC0E6D8")]
		private bool CheckIsInRoom()
		{
			return default(bool);
		}

		// Token: 0x06004C19 RID: 19481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C19")]
		[Address(RVA = "0x1409328", Offset = "0x1409328", VA = "0x7BBBC09328")]
		private void OnDisconnected_CustomRoom()
		{
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1A")]
		[Address(RVA = "0x140E7C0", Offset = "0x140E7C0", VA = "0x7BBBC0E7C0")]
		private void OnMsgElitePass(MessageNotify res)
		{
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1B")]
		[Address(RVA = "0x140E340", Offset = "0x140E340", VA = "0x7BBBC0E340")]
		private void PopupErrWindow(Dictionary<uint, string> errMsgDict, uint errCode, bool cleanAllPopups = true)
		{
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1C")]
		[Address(RVA = "0x140EAC0", Offset = "0x140EAC0", VA = "0x7BBBC0EAC0")]
		private void OnMsgFriend(MessageNotify res)
		{
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1D")]
		[Address(RVA = "0x140EE28", Offset = "0x140EE28", VA = "0x7BBBC0EE28")]
		private void OnMsgFriend_Remove(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1E")]
		[Address(RVA = "0x140FAD4", Offset = "0x140FAD4", VA = "0x7BBBC0FAD4")]
		private void OnReceiveIntimacyChange(byte[] data)
		{
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1F")]
		[Address(RVA = "0x140F94C", Offset = "0x140F94C", VA = "0x7BBBC0F94C")]
		private void OnReceiveRelationshipMsgInfo(byte[] data, tcp.EFriend.Proto cmdType)
		{
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C20")]
		[Address(RVA = "0x140EF4C", Offset = "0x140EF4C", VA = "0x7BBBC0EF4C")]
		private void OnMsgFriend_ConfirmAdd(uint res, byte[] data)
		{
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C21")]
		[Address(RVA = "0x140F308", Offset = "0x140F308", VA = "0x7BBBC0F308")]
		private void OnMsgFriend_ConfidantOnline(uint res, byte[] data)
		{
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C22")]
		[Address(RVA = "0x140FC1C", Offset = "0x140FC1C", VA = "0x7BBBC0FC1C")]
		private void OnMsgGroup(MessageNotify res)
		{
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C23")]
		[Address(RVA = "0x14104E0", Offset = "0x14104E0", VA = "0x7BBBC104E0")]
		private void OnMsgGroup_Create(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C24")]
		[Address(RVA = "0x14113D4", Offset = "0x14113D4", VA = "0x7BBBC113D4")]
		private void OnMsgGroup_LeaveNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C25")]
		[Address(RVA = "0x14107B8", Offset = "0x14107B8", VA = "0x7BBBC107B8")]
		private void OnMsgGroup_InviteNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C26")]
		[Address(RVA = "0x1413954", Offset = "0x1413954", VA = "0x7BBBC13954")]
		private void OnMsgGroup_JoinRequestNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C27")]
		[Address(RVA = "0x1413B40", Offset = "0x1413B40", VA = "0x7BBBC13B40")]
		private void OnMsgGroup_ChangePublic(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C28")]
		[Address(RVA = "0x1413CA0", Offset = "0x1413CA0", VA = "0x7BBBC13CA0")]
		private void OnMsgGroup_CSRANKINGBAN(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x1410A14", Offset = "0x1410A14", VA = "0x7BBBC10A14")]
		private void OnMsgGroup_JoinNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2A")]
		[Address(RVA = "0x14122C0", Offset = "0x14122C0", VA = "0x7BBBC122C0")]
		private void OnMsgGroup_Info(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2B")]
		[Address(RVA = "0x14117C8", Offset = "0x14117C8", VA = "0x7BBBC117C8")]
		private void OnMsgGroup_StartNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C2C RID: 19500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2C")]
		[Address(RVA = "0x1411ADC", Offset = "0x1411ADC", VA = "0x7BBBC11ADC")]
		private void OnMsgGroup_StopNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2D")]
		[Address(RVA = "0x1411F18", Offset = "0x1411F18", VA = "0x7BBBC11F18")]
		private void OnMsgGroup_DismissNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2E")]
		[Address(RVA = "0x1412D64", Offset = "0x1412D64", VA = "0x7BBBC12D64")]
		private void OnMsgGroup_ShowEmoteNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2F")]
		[Address(RVA = "0x1412F48", Offset = "0x1412F48", VA = "0x7BBBC12F48")]
		private void OnMsgGroup_ShowPetActionNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C30")]
		[Address(RVA = "0x1413064", Offset = "0x1413064", VA = "0x7BBBC13064")]
		private void OnMsgGroup_ShowAntiAddiction(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C31")]
		[Address(RVA = "0x1413548", Offset = "0x1413548", VA = "0x7BBBC13548")]
		private void OnMsgGroup_ShowTeamMateCheating(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C32")]
		[Address(RVA = "0x14091E4", Offset = "0x14091E4", VA = "0x7BBBC091E4")]
		private void OnDisconnected_Group()
		{
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C33")]
		[Address(RVA = "0x1413EE4", Offset = "0x1413EE4", VA = "0x7BBBC13EE4")]
		private void OnMsgGroup_Ready(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C34")]
		[Address(RVA = "0x1412530", Offset = "0x1412530", VA = "0x7BBBC12530")]
		private void OnMsgGroup_ReadyNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C35")]
		[Address(RVA = "0x1412804", Offset = "0x1412804", VA = "0x7BBBC12804")]
		private void OnMsgGroup_ChangeNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C36")]
		[Address(RVA = "0x1412C80", Offset = "0x1412C80", VA = "0x7BBBC12C80")]
		private void OnMsgGroup_ChangeMapNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C37 RID: 19511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C37")]
		[Address(RVA = "0x1410428", Offset = "0x1410428", VA = "0x7BBBC10428")]
		private void UpdateGroupInfo(GroupInfo resData, bool isNew = false)
		{
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C38")]
		[Address(RVA = "0x1413E40", Offset = "0x1413E40", VA = "0x7BBBC13E40")]
		private void UpdateGroupMatchMakingStatus(bool v)
		{
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x141379C", Offset = "0x141379C", VA = "0x7BBBC1379C")]
		private void OnMsgGroup_GetGroupCodeNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0x1413A70", Offset = "0x1413A70", VA = "0x7BBBC13A70")]
		private void OnChangeAvailableMapsNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3B")]
		[Address(RVA = "0x14140E0", Offset = "0x14140E0", VA = "0x7BBBC140E0")]
		private void OnMsgInventory(MessageNotify res)
		{
		}

		// Token: 0x06004C3C RID: 19516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3C")]
		[Address(RVA = "0x1414D2C", Offset = "0x1414D2C", VA = "0x7BBBC14D2C")]
		private void OnMsgBackpack(MessageNotify res)
		{
		}

		// Token: 0x06004C3D RID: 19517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3D")]
		[Address(RVA = "0x1414E00", Offset = "0x1414E00", VA = "0x7BBBC14E00")]
		private void OnMsgLimitedEvent(MessageNotify res)
		{
		}

		// Token: 0x06004C3E RID: 19518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3E")]
		[Address(RVA = "0x14151F8", Offset = "0x14151F8", VA = "0x7BBBC151F8")]
		private void OnMsgMail(MessageNotify res)
		{
		}

		// Token: 0x06004C3F RID: 19519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C3F")]
		[Address(RVA = "0x1415640", Offset = "0x1415640", VA = "0x7BBBC15640")]
		private void OnMsgMatchMaking(MessageNotify res)
		{
		}

		// Token: 0x06004C40 RID: 19520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C40")]
		[Address(RVA = "0x1416BD4", Offset = "0x1416BD4", VA = "0x7BBBC16BD4")]
		private void OnMsgMatchMakingStartNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C41")]
		[Address(RVA = "0x1416434", Offset = "0x1416434", VA = "0x7BBBC16434")]
		private void OnMsgMatchMakingSussNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C42")]
		[Address(RVA = "0x1416CF0", Offset = "0x1416CF0", VA = "0x7BBBC16CF0")]
		private void OnMsgGameOpeningInfoNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C43")]
		[Address(RVA = "0x1416DC0", Offset = "0x1416DC0", VA = "0x7BBBC16DC0")]
		private void OnMsgGameAntiAddicTionNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C44")]
		[Address(RVA = "0x1409284", Offset = "0x1409284", VA = "0x7BBBC09284")]
		private void OnDisconnected_MatchMaking()
		{
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C45")]
		[Address(RVA = "0x1417098", Offset = "0x1417098", VA = "0x7BBBC17098")]
		private void OnMsgMatchStats(MessageNotify res)
		{
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C46")]
		[Address(RVA = "0x141735C", Offset = "0x141735C", VA = "0x7BBBC1735C")]
		private void OnMsgAntiaddiction(MessageNotify res)
		{
		}

		// Token: 0x06004C47 RID: 19527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C47")]
		[Address(RVA = "0x1417C68", Offset = "0x1417C68", VA = "0x7BBBC17C68")]
		private void OnMsgMtp(MessageNotify res)
		{
		}

		// Token: 0x06004C48 RID: 19528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C48")]
		[Address(RVA = "0x1417EDC", Offset = "0x1417EDC", VA = "0x7BBBC17EDC")]
		private void OnLightFeatureNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C49 RID: 19529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C49")]
		[Address(RVA = "0x1418288", Offset = "0x1418288", VA = "0x7BBBC18288")]
		private void OnSendDataToClientNtf(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4A")]
		[Address(RVA = "0x1418324", Offset = "0x1418324", VA = "0x7BBBC18324")]
		private void OnMsgPetExpChange(MessageNotify res)
		{
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4B")]
		[Address(RVA = "0x1418410", Offset = "0x1418410", VA = "0x7BBBC18410")]
		private void OnMsgPresence(MessageNotify res)
		{
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4C")]
		[Address(RVA = "0x1418654", Offset = "0x1418654", VA = "0x7BBBC18654")]
		private void OnTCPPresnceListNtf(byte[] data)
		{
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x1418A08", Offset = "0x1418A08", VA = "0x7BBBC18A08")]
		private void OnMsgReconnection(MessageNotify res)
		{
		}

		// Token: 0x06004C4E RID: 19534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4E")]
		[Address(RVA = "0x1418E04", Offset = "0x1418E04", VA = "0x7BBBC18E04")]
		private void OnMsgHasLatestGameInfo(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4F")]
		[Address(RVA = "0x1419358", Offset = "0x1419358", VA = "0x7BBBC19358")]
		private void OnMsgHasLatestRoomInfo(uint ret, byte[] data)
		{
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C50")]
		[Address(RVA = "0x14197DC", Offset = "0x14197DC", VA = "0x7BBBC197DC")]
		private void OnMsgStore(MessageNotify res)
		{
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C51")]
		[Address(RVA = "0x1419BA8", Offset = "0x1419BA8", VA = "0x7BBBC19BA8")]
		private void OnMsgUpdateUser(MessageNotify res)
		{
		}

		// Token: 0x040073ED RID: 29677
		[Token(Token = "0x40073ED")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<uint, string> MATCHMAKING_ERR_MESSAGE_DICT;

		// Token: 0x040073EE RID: 29678
		[Token(Token = "0x40073EE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<uint, string> GROUP_ERR_MESSAGE_DICT;

		// Token: 0x040073EF RID: 29679
		[Token(Token = "0x40073EF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<uint, string> CUSTOMROOM_ERR_MESSAGE_DICT;

		// Token: 0x040073F0 RID: 29680
		[Token(Token = "0x40073F0")]
		[FieldOffset(Offset = "0x18")]
		private static LobbyServiceConnectionHandler.FreatureCache lite_datas;

		// Token: 0x020012DB RID: 4827
		[Token(Token = "0x20012DB")]
		private struct FreatureCache
		{
			// Token: 0x040073F1 RID: 29681
			[Token(Token = "0x40073F1")]
			[FieldOffset(Offset = "0x0")]
			public string feature_name;

			// Token: 0x040073F2 RID: 29682
			[Token(Token = "0x40073F2")]
			[FieldOffset(Offset = "0x8")]
			public byte[] feature_data;

			// Token: 0x040073F3 RID: 29683
			[Token(Token = "0x40073F3")]
			[FieldOffset(Offset = "0x10")]
			public uint data_len;

			// Token: 0x040073F4 RID: 29684
			[Token(Token = "0x40073F4")]
			[FieldOffset(Offset = "0x14")]
			public uint data_crc;
		}

		// Token: 0x020012DC RID: 4828
		[Token(Token = "0x20012DC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB0E8", Offset = "0x10EB0E8")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004C54 RID: 19540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C54")]
			[Address(RVA = "0x1A4DC34", Offset = "0x1A4DC34", VA = "0x7BBC24DC34")]
			public <>c()
			{
			}

			// Token: 0x06004C55 RID: 19541 RVA: 0x00016D10 File Offset: 0x00014F10
			[Token(Token = "0x6004C55")]
			[Address(RVA = "0x1A4DC3C", Offset = "0x1A4DC3C", VA = "0x7BBC24DC3C")]
			internal bool <OnMsgCustomRoom>b__7_0(RoomPlayerInfo a)
			{
				return default(bool);
			}

			// Token: 0x06004C56 RID: 19542 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004C56")]
			[Address(RVA = "0x1A4DD0C", Offset = "0x1A4DD0C", VA = "0x7BBC24DD0C")]
			internal string <OnMsgCustomRoom>b__7_1(ulong e)
			{
				return null;
			}

			// Token: 0x06004C57 RID: 19543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004C57")]
			[Address(RVA = "0x1A4DD34", Offset = "0x1A4DD34", VA = "0x7BBC24DD34")]
			internal string <OnMsgCustomRoom>b__7_2(ulong i)
			{
				return null;
			}

			// Token: 0x06004C58 RID: 19544 RVA: 0x00016D28 File Offset: 0x00014F28
			[Token(Token = "0x6004C58")]
			[Address(RVA = "0x1A4DD5C", Offset = "0x1A4DD5C", VA = "0x7BBC24DD5C")]
			internal bool <OnMsgGroup_JoinNtf>b__29_0(GroupMemberInfo m)
			{
				return default(bool);
			}

			// Token: 0x06004C59 RID: 19545 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C59")]
			[Address(RVA = "0x1A4DDF0", Offset = "0x1A4DDF0", VA = "0x7BBC24DDF0")]
			internal void <OnLightFeatureNtf>b__62_0()
			{
			}

			// Token: 0x06004C5A RID: 19546 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C5A")]
			[Address(RVA = "0x1A4DEFC", Offset = "0x1A4DEFC", VA = "0x7BBC24DEFC")]
			internal void <OnMsgHasLatestRoomInfo>b__69_0()
			{
			}

			// Token: 0x040073F5 RID: 29685
			[Token(Token = "0x40073F5")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LobbyServiceConnectionHandler.<>c <>9;

			// Token: 0x040073F6 RID: 29686
			[Token(Token = "0x40073F6")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<RoomPlayerInfo> <>9__7_0;

			// Token: 0x040073F7 RID: 29687
			[Token(Token = "0x40073F7")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<ulong, string> <>9__7_1;

			// Token: 0x040073F8 RID: 29688
			[Token(Token = "0x40073F8")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<ulong, string> <>9__7_2;

			// Token: 0x040073F9 RID: 29689
			[Token(Token = "0x40073F9")]
			[FieldOffset(Offset = "0x20")]
			public static Predicate<GroupMemberInfo> <>9__29_0;

			// Token: 0x040073FA RID: 29690
			[Token(Token = "0x40073FA")]
			[FieldOffset(Offset = "0x28")]
			public static Action <>9__62_0;

			// Token: 0x040073FB RID: 29691
			[Token(Token = "0x40073FB")]
			[FieldOffset(Offset = "0x30")]
			public static Action <>9__69_0;
		}

		// Token: 0x020012DD RID: 4829
		[Token(Token = "0x20012DD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB0F8", Offset = "0x10EB0F8")]
		private sealed class <>c__DisplayClass29_0
		{
			// Token: 0x06004C5B RID: 19547 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C5B")]
			[Address(RVA = "0x1A4E190", Offset = "0x1A4E190", VA = "0x7BBC24E190")]
			public <>c__DisplayClass29_0()
			{
			}

			// Token: 0x06004C5C RID: 19548 RVA: 0x00016D40 File Offset: 0x00014F40
			[Token(Token = "0x6004C5C")]
			[Address(RVA = "0x1A4E198", Offset = "0x1A4E198", VA = "0x7BBC24E198")]
			internal bool <OnMsgGroup_JoinNtf>b__1(GroupMemberInfo x)
			{
				return default(bool);
			}

			// Token: 0x040073FC RID: 29692
			[Token(Token = "0x40073FC")]
			[FieldOffset(Offset = "0x10")]
			public GroupMemberInfo memberNew;
		}

		// Token: 0x020012DE RID: 4830
		[Token(Token = "0x20012DE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB108", Offset = "0x10EB108")]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x06004C5D RID: 19549 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C5D")]
			[Address(RVA = "0x1A4E1F8", Offset = "0x1A4E1F8", VA = "0x7BBC24E1F8")]
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x06004C5E RID: 19550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C5E")]
			[Address(RVA = "0x1A4E200", Offset = "0x1A4E200", VA = "0x7BBC24E200")]
			internal void <OnMsgMatchMaking>b__0()
			{
			}

			// Token: 0x040073FD RID: 29693
			[Token(Token = "0x40073FD")]
			[FieldOffset(Offset = "0x10")]
			public LobbyServiceConnectionHandler <>4__this;

			// Token: 0x040073FE RID: 29694
			[Token(Token = "0x40073FE")]
			[FieldOffset(Offset = "0x18")]
			public MessageNotify res;
		}
	}
}
