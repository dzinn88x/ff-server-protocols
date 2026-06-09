using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001FDA RID: 8154
	[Token(Token = "0x2001FDA")]
	public class UIModelRelationShip : UIBaseModel
	{
		// Token: 0x0600B4FC RID: 46332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4FC")]
		[Address(RVA = "0x239C3E0", Offset = "0x239C3E0", VA = "0x7BBCB9C3E0")]
		public RelationshipInfo GetRelationshipInfoAlreadyBe(proto.EFriend.RelationType relationType, ulong accountID)
		{
			return null;
		}

		// Token: 0x0600B4FD RID: 46333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B4FD")]
		[Address(RVA = "0x239C5F0", Offset = "0x239C5F0", VA = "0x7BBCB9C5F0")]
		public RelationshipInfo GetRelationshipInfo(proto.EFriend.RelationType relationType, ulong accountID)
		{
			return null;
		}

		// Token: 0x0600B4FE RID: 46334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4FE")]
		[Address(RVA = "0x239C7A8", Offset = "0x239C7A8", VA = "0x7BBCB9C7A8")]
		public void SetCurrentAllNotifyMsgRead()
		{
		}

		// Token: 0x0600B4FF RID: 46335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B4FF")]
		[Address(RVA = "0x239CA88", Offset = "0x239CA88", VA = "0x7BBCB9CA88")]
		public void DeclineAndReadCurrentAllMsg()
		{
		}

		// Token: 0x0600B500 RID: 46336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B500")]
		[Address(RVA = "0x239C8F8", Offset = "0x239C8F8", VA = "0x7BBCB9C8F8")]
		public void CheckNewRelationshipMsg()
		{
		}

		// Token: 0x0600B501 RID: 46337 RVA: 0x000335E8 File Offset: 0x000317E8
		[Token(Token = "0x600B501")]
		[Address(RVA = "0x239CBE4", Offset = "0x239CBE4", VA = "0x7BBCB9CBE4")]
		public bool RelationshipInfoVisible(proto.EFriend.RelationType relationType)
		{
			return default(bool);
		}

		// Token: 0x0600B502 RID: 46338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B502")]
		[Address(RVA = "0x239CD20", Offset = "0x239CD20", VA = "0x7BBCB9CD20")]
		public List<RelationshipMessageInfo> GetRelationshipApplications()
		{
			return null;
		}

		// Token: 0x0600B503 RID: 46339 RVA: 0x00033600 File Offset: 0x00031800
		[Token(Token = "0x600B503")]
		[Address(RVA = "0x239CEDC", Offset = "0x239CEDC", VA = "0x7BBCB9CEDC")]
		public bool HasRelationshipDismissApplication(proto.EFriend.RelationType relationType)
		{
			return default(bool);
		}

		// Token: 0x0600B504 RID: 46340 RVA: 0x00033618 File Offset: 0x00031818
		[Token(Token = "0x600B504")]
		[Address(RVA = "0x239D024", Offset = "0x239D024", VA = "0x7BBCB9D024")]
		public ulong GetRelationshipDismissApplicationReqTime(proto.EFriend.RelationType relationType)
		{
			return 0UL;
		}

		// Token: 0x0600B505 RID: 46341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B505")]
		[Address(RVA = "0x239D16C", Offset = "0x239D16C", VA = "0x7BBCB9D16C")]
		public SpecificIntimacyRankAwardInfo GetIntimacyRewardInfo(ulong relationshipID)
		{
			return null;
		}

		// Token: 0x0600B506 RID: 46342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B506")]
		[Address(RVA = "0x239D1EC", Offset = "0x239D1EC", VA = "0x7BBCB9D1EC")]
		public List<RelationshipInfo> GetCurrentRelationInfoAlreadyBe(proto.EFriend.RelationType relationType)
		{
			return null;
		}

		// Token: 0x0600B507 RID: 46343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B507")]
		[Address(RVA = "0x239CCA0", Offset = "0x239CCA0", VA = "0x7BBCB9CCA0")]
		public List<RelationshipInfo> GetCurrentRelationInfo(proto.EFriend.RelationType relationType)
		{
			return null;
		}

		// Token: 0x0600B508 RID: 46344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B508")]
		[Address(RVA = "0x239D3D0", Offset = "0x239D3D0", VA = "0x7BBCB9D3D0")]
		public List<FriendAccountInfo> GetRelationshipCandidateList(proto.EFriend.RelationType relationType)
		{
			return null;
		}

		// Token: 0x0600B509 RID: 46345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B509")]
		[Address(RVA = "0x239D91C", Offset = "0x239D91C", VA = "0x7BBCB9D91C")]
		public Dictionary<uint, IntimacyAwardDesc> GetIntimacyAwardsDesc(proto.EFriend.RelationType relationType)
		{
			return null;
		}

		// Token: 0x0600B50A RID: 46346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B50A")]
		[Address(RVA = "0x239D9A4", Offset = "0x239D9A4", VA = "0x7BBCB9D9A4")]
		public IntimacyRankAwardInfo GetIntimacyAwardsInfo(ulong friendID, uint rank)
		{
			return null;
		}

		// Token: 0x0600B50B RID: 46347 RVA: 0x00033630 File Offset: 0x00031830
		[Token(Token = "0x600B50B")]
		[Address(RVA = "0x239DB0C", Offset = "0x239DB0C", VA = "0x7BBCB9DB0C")]
		public int GetIntimacyMax(proto.EFriend.RelationType relationType)
		{
			return 0;
		}

		// Token: 0x0600B50C RID: 46348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B50C")]
		[Address(RVA = "0x239DD48", Offset = "0x239DD48", VA = "0x7BBCB9DD48")]
		public IntimacyRankInfoData GetIntimacyRankInfoByIntimacy(proto.EFriend.RelationType relationType, uint intimacy)
		{
			return null;
		}

		// Token: 0x0600B50D RID: 46349 RVA: 0x00033648 File Offset: 0x00031848
		[Token(Token = "0x600B50D")]
		[Address(RVA = "0x239DF88", Offset = "0x239DF88", VA = "0x7BBCB9DF88")]
		public proto.EFriend.RelationType GetRelationship(ulong FriendID)
		{
			return proto.EFriend.RelationType.RelationType_NONE;
		}

		// Token: 0x0600B50E RID: 46350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B50E")]
		[Address(RVA = "0x239E2C4", Offset = "0x239E2C4", VA = "0x7BBCB9E2C4")]
		public List<RelationshipInfo> GetRelationshipsByFriendID(ulong FriendID)
		{
			return null;
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B50F")]
		[Address(RVA = "0x239E5F4", Offset = "0x239E5F4", VA = "0x7BBCB9E5F4")]
		public List<ulong> GetRelationshipFriendIDsInLocationData(proto.EFriend.RelationType relationType)
		{
			return null;
		}

		// Token: 0x0600B510 RID: 46352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B510")]
		[Address(RVA = "0x239E824", Offset = "0x239E824", VA = "0x7BBCB9E824")]
		public void SetRelationshipFriendIDsInLocationData(proto.EFriend.RelationType relationType)
		{
		}

		// Token: 0x0600B511 RID: 46353 RVA: 0x00033660 File Offset: 0x00031860
		[Token(Token = "0x600B511")]
		[Address(RVA = "0x239EAD0", Offset = "0x239EAD0", VA = "0x7BBCB9EAD0")]
		public uint GetRelationshipRank(ulong FriendID, proto.EFriend.RelationType relationType)
		{
			return 0U;
		}

		// Token: 0x0600B512 RID: 46354 RVA: 0x00033678 File Offset: 0x00031878
		[Token(Token = "0x600B512")]
		[Address(RVA = "0x239D714", Offset = "0x239D714", VA = "0x7BBCB9D714")]
		private bool CheckRelationshipStateIsConnect(proto.EFriend.RelationType relationType, ulong accountID)
		{
			return default(bool);
		}

		// Token: 0x0600B513 RID: 46355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B513")]
		[Address(RVA = "0x239EB40", Offset = "0x239EB40", VA = "0x7BBCB9EB40")]
		private RelationshipMessageInfo GetSepcialFriendApplication(proto.EFriend.RelationType relationType, ulong accountID)
		{
			return null;
		}

		// Token: 0x0600B514 RID: 46356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B514")]
		[Address(RVA = "0x239ECF0", Offset = "0x239ECF0", VA = "0x7BBCB9ECF0")]
		private IntimacyAwardDesc GetAwardDesc(proto.EFriend.RelationType relationType, uint rank)
		{
			return null;
		}

		// Token: 0x0600B515 RID: 46357 RVA: 0x00033690 File Offset: 0x00031890
		[Token(Token = "0x600B515")]
		[Address(RVA = "0x239EDC0", Offset = "0x239EDC0", VA = "0x7BBCB9EDC0", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B516")]
		[Address(RVA = "0x239EDC8", Offset = "0x239EDC8", VA = "0x7BBCB9EDC8", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600B517 RID: 46359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B517")]
		[Address(RVA = "0x239EF84", Offset = "0x239EF84", VA = "0x7BBCB9EF84", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B518")]
		[Address(RVA = "0x239F078", Offset = "0x239F078", VA = "0x7BBCB9F078")]
		public void RequestAuthInspect(bool visible)
		{
		}

		// Token: 0x0600B519 RID: 46361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B519")]
		[Address(RVA = "0x239F2EC", Offset = "0x239F2EC", VA = "0x7BBCB9F2EC")]
		public void RequestClaimIntimacyAward(ulong friendID, uint rankLevel, proto.EFriend.RelationType relationType)
		{
		}

		// Token: 0x0600B51A RID: 46362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B51A")]
		[Address(RVA = "0x239F558", Offset = "0x239F558", VA = "0x7BBCB9F558")]
		public void RequestIntimacyRankAwardsInfo(bool force = false)
		{
		}

		// Token: 0x0600B51B RID: 46363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B51B")]
		[Address(RVA = "0x239F754", Offset = "0x239F754", VA = "0x7BBCB9F754")]
		public void RequestCreateSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
		{
		}

		// Token: 0x0600B51C RID: 46364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B51C")]
		[Address(RVA = "0x239FA8C", Offset = "0x239FA8C", VA = "0x7BBCB9FA8C")]
		public void RequestDismissSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
		{
		}

		// Token: 0x0600B51D RID: 46365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B51D")]
		[Address(RVA = "0x239FDC0", Offset = "0x239FDC0", VA = "0x7BBCB9FDC0")]
		public void RequestRelationShipInvitationInfos(bool force = false)
		{
		}

		// Token: 0x0600B51E RID: 46366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B51E")]
		[Address(RVA = "0x239FF98", Offset = "0x239FF98", VA = "0x7BBCB9FF98")]
		public void RequestAllRelationshipStateInfo(bool isFirstLogin, bool force = false)
		{
		}

		// Token: 0x0600B51F RID: 46367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B51F")]
		[Address(RVA = "0x23A0188", Offset = "0x23A0188", VA = "0x7BBCBA0188")]
		public void RequestConfirmCreateSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
		{
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B520")]
		[Address(RVA = "0x23A03D4", Offset = "0x23A03D4", VA = "0x7BBCBA03D4")]
		public void RequestConfirmDismissSpecialRelation(proto.EFriend.RelationType relationType, ulong accountID)
		{
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B521")]
		[Address(RVA = "0x23A061C", Offset = "0x23A061C", VA = "0x7BBCBA061C")]
		public void RequestDeclineCreateSpecialFriend(proto.EFriend.RelationType relationType, ulong accountID)
		{
		}

		// Token: 0x0600B522 RID: 46370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B522")]
		[Address(RVA = "0x23A0860", Offset = "0x23A0860", VA = "0x7BBCBA0860")]
		public void RequestDeclineDissmissSpecialFriend(proto.EFriend.RelationType relationType, ulong accountID)
		{
		}

		// Token: 0x0600B523 RID: 46371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B523")]
		[Address(RVA = "0x23A0AA0", Offset = "0x23A0AA0", VA = "0x7BBCBA0AA0")]
		public void RequestCallbackDismissSpecialFriend(proto.EFriend.RelationType relationType, ulong accountID)
		{
		}

		// Token: 0x0600B524 RID: 46372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B524")]
		[Address(RVA = "0x23A0CE8", Offset = "0x23A0CE8", VA = "0x7BBCBA0CE8")]
		public void OnReceiveRelationshipMsgInfo(RelatedFriendRequestNtf receiveMsg, UIRelationshipMsgType msgType)
		{
		}

		// Token: 0x0600B525 RID: 46373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B525")]
		[Address(RVA = "0x23A13C0", Offset = "0x23A13C0", VA = "0x7BBCBA13C0")]
		public void OnReceiveIntimacyChange(ulong friendID, proto.EFriend.RelationType relationType, uint changeValue)
		{
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x0600B526 RID: 46374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C45")]
		public List<ulong> LastPlayGameFriends
		{
			[Token(Token = "0x600B526")]
			[Address(RVA = "0x23A17D8", Offset = "0x23A17D8", VA = "0x7BBCBA17D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B527 RID: 46375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B527")]
		[Address(RVA = "0x23A184C", Offset = "0x23A184C", VA = "0x7BBCBA184C")]
		public void AddLastPlayGameFriend(MatchStats stats)
		{
		}

		// Token: 0x0600B528 RID: 46376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B528")]
		[Address(RVA = "0x239EDCC", Offset = "0x239EDCC", VA = "0x7BBCB9EDCC")]
		public void InitLastPlayGameFriend()
		{
		}

		// Token: 0x0600B529 RID: 46377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B529")]
		[Address(RVA = "0x23A1C88", Offset = "0x23A1C88", VA = "0x7BBCBA1C88")]
		public UIModelRelationShip()
		{
		}

		// Token: 0x0600B52A RID: 46378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B52A")]
		[Address(RVA = "0x23A1D90", Offset = "0x23A1D90", VA = "0x7BBCBA1D90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146E3C", Offset = "0x1146E3C")]
		private void <RequestIntimacyRankAwardsInfo>b__46_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B52B RID: 46379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B52B")]
		[Address(RVA = "0x23A2170", Offset = "0x23A2170", VA = "0x7BBCBA2170")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146E4C", Offset = "0x1146E4C")]
		private void <RequestDismissSpecialRelation>b__48_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B52C RID: 46380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B52C")]
		[Address(RVA = "0x23A21B0", Offset = "0x23A21B0", VA = "0x7BBCBA21B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146E5C", Offset = "0x1146E5C")]
		private void <RequestRelationShipInvitationInfos>b__49_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0600B52D RID: 46381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B52D")]
		[Address(RVA = "0x23A2438", Offset = "0x23A2438", VA = "0x7BBCBA2438")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1146E6C", Offset = "0x1146E6C")]
		private void <RequestAllRelationshipStateInfo>b__50_0(HttpErrorCode errorCode, object res)
		{
		}

		// Token: 0x0400B759 RID: 46937
		[Token(Token = "0x400B759")]
		public const uint PropID_RelationshipInfoReady = 1U;

		// Token: 0x0400B75A RID: 46938
		[Token(Token = "0x400B75A")]
		public const uint PropID_UpdateRelationshipInviteState = 2U;

		// Token: 0x0400B75B RID: 46939
		[Token(Token = "0x400B75B")]
		public const uint PropID_UpdateRelationshipApplications = 4U;

		// Token: 0x0400B75C RID: 46940
		[Token(Token = "0x400B75C")]
		public const uint PropID_UpdateApplicationMsgInfoState = 8U;

		// Token: 0x0400B75D RID: 46941
		[Token(Token = "0x400B75D")]
		public const uint PropID_ClaimRelationshipRewards = 16U;

		// Token: 0x0400B75E RID: 46942
		[Token(Token = "0x400B75E")]
		public const uint PropID_UpdateIntimacyChange = 32U;

		// Token: 0x0400B75F RID: 46943
		[Token(Token = "0x400B75F")]
		public const uint PropID_UpdateRelationshipVisible = 64U;

		// Token: 0x0400B760 RID: 46944
		[Token(Token = "0x400B760")]
		public const uint PropID_RelationshipIntimacyInfoReady = 128U;

		// Token: 0x0400B761 RID: 46945
		[Token(Token = "0x400B761")]
		private const string SHOW_CELEBERATE_CONNECT_WITH_FRIEND = "Congratulation_{0}";

		// Token: 0x0400B762 RID: 46946
		[Token(Token = "0x400B762")]
		[FieldOffset(Offset = "0x18")]
		private bool m_RelationshipDicReady;

		// Token: 0x0400B763 RID: 46947
		[Token(Token = "0x400B763")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<proto.EFriend.RelationType, List<RelationshipInfo>> m_RelationshipDic;

		// Token: 0x0400B764 RID: 46948
		[Token(Token = "0x400B764")]
		[FieldOffset(Offset = "0x28")]
		private bool m_IntimacyAwardInfoDicReady;

		// Token: 0x0400B765 RID: 46949
		[Token(Token = "0x400B765")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<ulong, SpecificIntimacyRankAwardInfo> m_IntimacyAwardInfoDic;

		// Token: 0x0400B766 RID: 46950
		[Token(Token = "0x400B766")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<proto.EFriend.RelationType, Dictionary<uint, IntimacyAwardDesc>> m_IntimacyAwardDescDic;

		// Token: 0x0400B767 RID: 46951
		[Token(Token = "0x400B767")]
		[FieldOffset(Offset = "0x40")]
		private bool m_ApplicationsListReady;

		// Token: 0x0400B768 RID: 46952
		[Token(Token = "0x400B768")]
		[FieldOffset(Offset = "0x48")]
		private List<RelationshipMessageInfo> m_ApplicationsList;

		// Token: 0x0400B769 RID: 46953
		[Token(Token = "0x400B769")]
		private const string RecordLastPlayGameFriendString = "LastPlayGameFriend";

		// Token: 0x0400B76A RID: 46954
		[Token(Token = "0x400B76A")]
		private const int RecordLastPlayGameFriendCount = 3;

		// Token: 0x0400B76B RID: 46955
		[Token(Token = "0x400B76B")]
		[FieldOffset(Offset = "0x50")]
		private List<ulong> m_LastPlayGameFriends;

		// Token: 0x02001FDB RID: 8155
		[Token(Token = "0x2001FDB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD614", Offset = "0x10FD614")]
		private sealed class <>c__DisplayClass44_0
		{
			// Token: 0x0600B52E RID: 46382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B52E")]
			[Address(RVA = "0x239F2E4", Offset = "0x239F2E4", VA = "0x7BBCB9F2E4")]
			public <>c__DisplayClass44_0()
			{
			}

			// Token: 0x0600B52F RID: 46383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B52F")]
			[Address(RVA = "0x23A2754", Offset = "0x23A2754", VA = "0x7BBCBA2754")]
			internal void <RequestAuthInspect>b__0(HttpErrorCode errorCode, object obj)
			{
			}

			// Token: 0x0400B76C RID: 46956
			[Token(Token = "0x400B76C")]
			[FieldOffset(Offset = "0x10")]
			public UIModelRelationShip <>4__this;

			// Token: 0x0400B76D RID: 46957
			[Token(Token = "0x400B76D")]
			[FieldOffset(Offset = "0x18")]
			public bool visible;
		}

		// Token: 0x02001FDC RID: 8156
		[Token(Token = "0x2001FDC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD624", Offset = "0x10FD624")]
		private sealed class <>c__DisplayClass45_0
		{
			// Token: 0x0600B530 RID: 46384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B530")]
			[Address(RVA = "0x239F550", Offset = "0x239F550", VA = "0x7BBCB9F550")]
			public <>c__DisplayClass45_0()
			{
			}

			// Token: 0x0600B531 RID: 46385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B531")]
			[Address(RVA = "0x23A28E0", Offset = "0x23A28E0", VA = "0x7BBCBA28E0")]
			internal void <RequestClaimIntimacyAward>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B76E RID: 46958
			[Token(Token = "0x400B76E")]
			[FieldOffset(Offset = "0x10")]
			public UIModelRelationShip <>4__this;

			// Token: 0x0400B76F RID: 46959
			[Token(Token = "0x400B76F")]
			[FieldOffset(Offset = "0x18")]
			public ulong friendID;

			// Token: 0x0400B770 RID: 46960
			[Token(Token = "0x400B770")]
			[FieldOffset(Offset = "0x20")]
			public uint rankLevel;
		}

		// Token: 0x02001FDD RID: 8157
		[Token(Token = "0x2001FDD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD634", Offset = "0x10FD634")]
		private sealed class <>c__DisplayClass47_0
		{
			// Token: 0x0600B532 RID: 46386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B532")]
			[Address(RVA = "0x239FA84", Offset = "0x239FA84", VA = "0x7BBCB9FA84")]
			public <>c__DisplayClass47_0()
			{
			}

			// Token: 0x0600B533 RID: 46387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B533")]
			[Address(RVA = "0x23A2B50", Offset = "0x23A2B50", VA = "0x7BBCBA2B50")]
			internal void <RequestCreateSpecialRelation>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B771 RID: 46961
			[Token(Token = "0x400B771")]
			[FieldOffset(Offset = "0x10")]
			public ulong accountID;

			// Token: 0x0400B772 RID: 46962
			[Token(Token = "0x400B772")]
			[FieldOffset(Offset = "0x18")]
			public proto.EFriend.RelationType relationType;

			// Token: 0x0400B773 RID: 46963
			[Token(Token = "0x400B773")]
			[FieldOffset(Offset = "0x20")]
			public RelationshipInfo currentRelationshipInfo;

			// Token: 0x0400B774 RID: 46964
			[Token(Token = "0x400B774")]
			[FieldOffset(Offset = "0x28")]
			public List<RelationshipInfo> accountInfoList;

			// Token: 0x0400B775 RID: 46965
			[Token(Token = "0x400B775")]
			[FieldOffset(Offset = "0x30")]
			public UIModelRelationShip <>4__this;
		}

		// Token: 0x02001FDE RID: 8158
		[Token(Token = "0x2001FDE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD644", Offset = "0x10FD644")]
		private sealed class <>c__DisplayClass51_0
		{
			// Token: 0x0600B534 RID: 46388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B534")]
			[Address(RVA = "0x23A03CC", Offset = "0x23A03CC", VA = "0x7BBCBA03CC")]
			public <>c__DisplayClass51_0()
			{
			}

			// Token: 0x0600B535 RID: 46389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B535")]
			[Address(RVA = "0x23A2DB8", Offset = "0x23A2DB8", VA = "0x7BBCBA2DB8")]
			internal void <RequestConfirmCreateSpecialRelation>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B776 RID: 46966
			[Token(Token = "0x400B776")]
			[FieldOffset(Offset = "0x10")]
			public proto.EFriend.RelationType relationType;

			// Token: 0x0400B777 RID: 46967
			[Token(Token = "0x400B777")]
			[FieldOffset(Offset = "0x18")]
			public UIModelRelationShip <>4__this;

			// Token: 0x0400B778 RID: 46968
			[Token(Token = "0x400B778")]
			[FieldOffset(Offset = "0x20")]
			public ulong accountID;
		}

		// Token: 0x02001FDF RID: 8159
		[Token(Token = "0x2001FDF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD654", Offset = "0x10FD654")]
		private sealed class <>c__DisplayClass52_0
		{
			// Token: 0x0600B536 RID: 46390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B536")]
			[Address(RVA = "0x23A0614", Offset = "0x23A0614", VA = "0x7BBCBA0614")]
			public <>c__DisplayClass52_0()
			{
			}

			// Token: 0x0600B537 RID: 46391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B537")]
			[Address(RVA = "0x23A32A4", Offset = "0x23A32A4", VA = "0x7BBCBA32A4")]
			internal void <RequestConfirmDismissSpecialRelation>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B779 RID: 46969
			[Token(Token = "0x400B779")]
			[FieldOffset(Offset = "0x10")]
			public UIModelRelationShip <>4__this;

			// Token: 0x0400B77A RID: 46970
			[Token(Token = "0x400B77A")]
			[FieldOffset(Offset = "0x18")]
			public proto.EFriend.RelationType relationType;

			// Token: 0x0400B77B RID: 46971
			[Token(Token = "0x400B77B")]
			[FieldOffset(Offset = "0x20")]
			public ulong accountID;
		}

		// Token: 0x02001FE0 RID: 8160
		[Token(Token = "0x2001FE0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD664", Offset = "0x10FD664")]
		private sealed class <>c__DisplayClass53_0
		{
			// Token: 0x0600B538 RID: 46392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B538")]
			[Address(RVA = "0x22F1A78", Offset = "0x22F1A78", VA = "0x7BBCAF1A78")]
			public <>c__DisplayClass53_0()
			{
			}

			// Token: 0x0600B539 RID: 46393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B539")]
			[Address(RVA = "0x22F1A80", Offset = "0x22F1A80", VA = "0x7BBCAF1A80")]
			internal void <RequestDeclineCreateSpecialFriend>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B77C RID: 46972
			[Token(Token = "0x400B77C")]
			[FieldOffset(Offset = "0x10")]
			public UIModelRelationShip <>4__this;

			// Token: 0x0400B77D RID: 46973
			[Token(Token = "0x400B77D")]
			[FieldOffset(Offset = "0x18")]
			public proto.EFriend.RelationType relationType;

			// Token: 0x0400B77E RID: 46974
			[Token(Token = "0x400B77E")]
			[FieldOffset(Offset = "0x20")]
			public ulong accountID;
		}

		// Token: 0x02001FE1 RID: 8161
		[Token(Token = "0x2001FE1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD674", Offset = "0x10FD674")]
		private sealed class <>c__DisplayClass54_0
		{
			// Token: 0x0600B53A RID: 46394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B53A")]
			[Address(RVA = "0x22F1B54", Offset = "0x22F1B54", VA = "0x7BBCAF1B54")]
			public <>c__DisplayClass54_0()
			{
			}

			// Token: 0x0600B53B RID: 46395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B53B")]
			[Address(RVA = "0x22F1B5C", Offset = "0x22F1B5C", VA = "0x7BBCAF1B5C")]
			internal void <RequestDeclineDissmissSpecialFriend>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B77F RID: 46975
			[Token(Token = "0x400B77F")]
			[FieldOffset(Offset = "0x10")]
			public UIModelRelationShip <>4__this;

			// Token: 0x0400B780 RID: 46976
			[Token(Token = "0x400B780")]
			[FieldOffset(Offset = "0x18")]
			public proto.EFriend.RelationType relationType;

			// Token: 0x0400B781 RID: 46977
			[Token(Token = "0x400B781")]
			[FieldOffset(Offset = "0x20")]
			public ulong accountID;
		}

		// Token: 0x02001FE2 RID: 8162
		[Token(Token = "0x2001FE2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FD684", Offset = "0x10FD684")]
		private sealed class <>c__DisplayClass55_0
		{
			// Token: 0x0600B53C RID: 46396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B53C")]
			[Address(RVA = "0x22F1CFC", Offset = "0x22F1CFC", VA = "0x7BBCAF1CFC")]
			public <>c__DisplayClass55_0()
			{
			}

			// Token: 0x0600B53D RID: 46397 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B53D")]
			[Address(RVA = "0x22F1D04", Offset = "0x22F1D04", VA = "0x7BBCAF1D04")]
			internal void <RequestCallbackDismissSpecialFriend>b__0(HttpErrorCode errorCode, object res)
			{
			}

			// Token: 0x0400B782 RID: 46978
			[Token(Token = "0x400B782")]
			[FieldOffset(Offset = "0x10")]
			public UIModelRelationShip <>4__this;

			// Token: 0x0400B783 RID: 46979
			[Token(Token = "0x400B783")]
			[FieldOffset(Offset = "0x18")]
			public proto.EFriend.RelationType relationType;

			// Token: 0x0400B784 RID: 46980
			[Token(Token = "0x400B784")]
			[FieldOffset(Offset = "0x20")]
			public ulong accountID;
		}
	}
}
