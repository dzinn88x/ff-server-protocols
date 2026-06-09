using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW
{
	// Token: 0x02001DDA RID: 7642
	[Token(Token = "0x2001DDA")]
	public class UIModelChat : UIBaseModel
	{
		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x0600A6E3 RID: 42723 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		[Token(Token = "0x17000AEC")]
		public ulong LastWorldSendTs
		{
			[Token(Token = "0x600A6E3")]
			[Address(RVA = "0x20F69E8", Offset = "0x20F69E8", VA = "0x7BBC8F69E8")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x0600A6E4 RID: 42724 RVA: 0x0002CDC0 File Offset: 0x0002AFC0
		[Token(Token = "0x17000AED")]
		public uint LeftWorldTalksTime
		{
			[Token(Token = "0x600A6E4")]
			[Address(RVA = "0x20F69F0", Offset = "0x20F69F0", VA = "0x7BBC8F69F0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x0600A6E5 RID: 42725 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		[Token(Token = "0x17000AEE")]
		public uint LeftWorlFastTimes
		{
			[Token(Token = "0x600A6E5")]
			[Address(RVA = "0x20F69F8", Offset = "0x20F69F8", VA = "0x7BBC8F69F8")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x0600A6E6 RID: 42726 RVA: 0x0002CDF0 File Offset: 0x0002AFF0
		[Token(Token = "0x17000AEF")]
		public bool EnableWorldCustomTalk
		{
			[Token(Token = "0x600A6E6")]
			[Address(RVA = "0x20F6A00", Offset = "0x20F6A00", VA = "0x7BBC8F6A00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x0600A6E7 RID: 42727 RVA: 0x0002CE08 File Offset: 0x0002B008
		// (set) Token: 0x0600A6E8 RID: 42728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF0")]
		public ulong MutedTimeStamp
		{
			[Token(Token = "0x600A6E7")]
			[Address(RVA = "0x20F6A08", Offset = "0x20F6A08", VA = "0x7BBC8F6A08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145CFC", Offset = "0x1145CFC")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600A6E8")]
			[Address(RVA = "0x20F6A10", Offset = "0x20F6A10", VA = "0x7BBC8F6A10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1145D0C", Offset = "0x1145D0C")]
			private set
			{
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x0600A6E9 RID: 42729 RVA: 0x0002CE20 File Offset: 0x0002B020
		// (set) Token: 0x0600A6EA RID: 42730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AF1")]
		public uint ChatReportTimes
		{
			[Token(Token = "0x600A6E9")]
			[Address(RVA = "0x20F6A18", Offset = "0x20F6A18", VA = "0x7BBC8F6A18")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600A6EA")]
			[Address(RVA = "0x20F6C98", Offset = "0x20F6C98", VA = "0x7BBC8F6C98")]
			private set
			{
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x0600A6EB RID: 42731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF2")]
		public List<ChatBlockUserInfo> ChatBlockList
		{
			[Token(Token = "0x600A6EB")]
			[Address(RVA = "0x20F6DA4", Offset = "0x20F6DA4", VA = "0x7BBC8F6DA4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x0600A6EC RID: 42732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF3")]
		public MessageInfo LatestMessage
		{
			[Token(Token = "0x600A6EC")]
			[Address(RVA = "0x20F6DAC", Offset = "0x20F6DAC", VA = "0x7BBC8F6DAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x0600A6ED RID: 42733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF4")]
		public List<ChatChannelInfo> ChannelInfoList
		{
			[Token(Token = "0x600A6ED")]
			[Address(RVA = "0x20F6DB4", Offset = "0x20F6DB4", VA = "0x7BBC8F6DB4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A6EE RID: 42734 RVA: 0x0002CE38 File Offset: 0x0002B038
		[Token(Token = "0x600A6EE")]
		[Address(RVA = "0x20F6E5C", Offset = "0x20F6E5C", VA = "0x7BBC8F6E5C", Slot = "6")]
		public override uint GetModelType()
		{
			return 0U;
		}

		// Token: 0x0600A6EF RID: 42735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6EF")]
		[Address(RVA = "0x20F6E64", Offset = "0x20F6E64", VA = "0x7BBC8F6E64", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x0600A6F0 RID: 42736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6F0")]
		[Address(RVA = "0x20F74C4", Offset = "0x20F74C4", VA = "0x7BBC8F74C4", Slot = "8")]
		public override void Login(params object[] data)
		{
		}

		// Token: 0x0600A6F1 RID: 42737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6F1")]
		[Address(RVA = "0x20F7620", Offset = "0x20F7620", VA = "0x7BBC8F7620", Slot = "9")]
		public override void Logout(params object[] data)
		{
		}

		// Token: 0x0600A6F2 RID: 42738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6F2")]
		[Address(RVA = "0x20F7058", Offset = "0x20F7058", VA = "0x7BBC8F7058")]
		private void ResetContinousChats()
		{
		}

		// Token: 0x0600A6F3 RID: 42739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6F3")]
		[Address(RVA = "0x20F7288", Offset = "0x20F7288", VA = "0x7BBC8F7288")]
		private void ReadBlockList()
		{
		}

		// Token: 0x0600A6F4 RID: 42740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6F4")]
		[Address(RVA = "0x20F78E0", Offset = "0x20F78E0", VA = "0x7BBC8F78E0")]
		public void JoinRoom(EChannel.ChannelType type, ulong roomid)
		{
		}

		// Token: 0x0600A6F5 RID: 42741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6F5")]
		[Address(RVA = "0x20F7DBC", Offset = "0x20F7DBC", VA = "0x7BBC8F7DBC")]
		public void AddWhisper(ulong id)
		{
		}

		// Token: 0x0600A6F6 RID: 42742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A6F6")]
		[Address(RVA = "0x20F7C74", Offset = "0x20F7C74", VA = "0x7BBC8F7C74")]
		public ChatChannelInfo GetChannelInfo(EChannel.ChannelType type, ulong id = 0UL)
		{
			return null;
		}

		// Token: 0x0600A6F7 RID: 42743 RVA: 0x0002CE50 File Offset: 0x0002B050
		[Token(Token = "0x600A6F7")]
		[Address(RVA = "0x20F8154", Offset = "0x20F8154", VA = "0x7BBC8F8154")]
		private int SortChannelList(ChatChannelInfo x, ChatChannelInfo y)
		{
			return 0;
		}

		// Token: 0x0600A6F8 RID: 42744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6F8")]
		[Address(RVA = "0x20F858C", Offset = "0x20F858C", VA = "0x7BBC8F858C")]
		public void LeaveRoom(EChannel.ChannelType type, ulong roomid)
		{
		}

		// Token: 0x0600A6F9 RID: 42745 RVA: 0x0002CE68 File Offset: 0x0002B068
		[Token(Token = "0x600A6F9")]
		[Address(RVA = "0x20F8B1C", Offset = "0x20F8B1C", VA = "0x7BBC8F8B1C")]
		public ulong GetWorldChannelID()
		{
			return 0UL;
		}

		// Token: 0x0600A6FA RID: 42746 RVA: 0x0002CE80 File Offset: 0x0002B080
		[Token(Token = "0x600A6FA")]
		[Address(RVA = "0x20F8B40", Offset = "0x20F8B40", VA = "0x7BBC8F8B40")]
		public bool IsWorldChannelOpen()
		{
			return default(bool);
		}

		// Token: 0x0600A6FB RID: 42747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6FB")]
		[Address(RVA = "0x20F8B6C", Offset = "0x20F8B6C", VA = "0x7BBC8F8B6C")]
		public void ProcessJoinWorldChannel()
		{
		}

		// Token: 0x0600A6FC RID: 42748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6FC")]
		[Address(RVA = "0x20F8C1C", Offset = "0x20F8C1C", VA = "0x7BBC8F8C1C")]
		public void SetWorldChannelID(ulong id)
		{
		}

		// Token: 0x0600A6FD RID: 42749 RVA: 0x0002CE98 File Offset: 0x0002B098
		[Token(Token = "0x600A6FD")]
		[Address(RVA = "0x20F8D58", Offset = "0x20F8D58", VA = "0x7BBC8F8D58")]
		public bool CorrectMessageContent(string msg, out string result)
		{
			return default(bool);
		}

		// Token: 0x0600A6FE RID: 42750 RVA: 0x0002CEB0 File Offset: 0x0002B0B0
		[Token(Token = "0x600A6FE")]
		[Address(RVA = "0x20F8E74", Offset = "0x20F8E74", VA = "0x7BBC8F8E74")]
		public bool SendFastGroupInvite(EChannel.ChannelType channel)
		{
			return default(bool);
		}

		// Token: 0x0600A6FF RID: 42751 RVA: 0x0002CEC8 File Offset: 0x0002B0C8
		[Token(Token = "0x600A6FF")]
		[Address(RVA = "0x20F92A8", Offset = "0x20F92A8", VA = "0x7BBC8F92A8")]
		public bool SendFastClanInvite(ClanInfo clanInfo)
		{
			return default(bool);
		}

		// Token: 0x0600A700 RID: 42752 RVA: 0x0002CEE0 File Offset: 0x0002B0E0
		[Token(Token = "0x600A700")]
		[Address(RVA = "0x20F9860", Offset = "0x20F9860", VA = "0x7BBC8F9860")]
		public bool SendFastChampionshipTeamInvite(EChannel.ChannelType channel, uint championshipType, uint championshipID)
		{
			return default(bool);
		}

		// Token: 0x0600A701 RID: 42753 RVA: 0x0002CEF8 File Offset: 0x0002B0F8
		[Token(Token = "0x600A701")]
		[Address(RVA = "0x20F9A18", Offset = "0x20F9A18", VA = "0x7BBC8F9A18")]
		public bool SendBigEventMsg(string msg, EChannel.ChannelType channel, ulong accountID = 0UL)
		{
			return default(bool);
		}

		// Token: 0x0600A702 RID: 42754 RVA: 0x0002CF10 File Offset: 0x0002B110
		[Token(Token = "0x600A702")]
		[Address(RVA = "0x20F923C", Offset = "0x20F923C", VA = "0x7BBC8F923C")]
		public bool SendMessage(EChannel.ChannelType type, string content, EChannel.MsgType msgType = EChannel.MsgType.MsgType_DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600A703 RID: 42755 RVA: 0x0002CF28 File Offset: 0x0002B128
		[Token(Token = "0x600A703")]
		[Address(RVA = "0x20F9A6C", Offset = "0x20F9A6C", VA = "0x7BBC8F9A6C")]
		public bool SendMessage(EChannel.ChannelType type, ulong channelID, string content, EChannel.MsgType msgType = EChannel.MsgType.MsgType_DEFAULT, bool checkFriend = true, float deltaCD = 0f, bool showWhisperFailTips = true)
		{
			return default(bool);
		}

		// Token: 0x0600A704 RID: 42756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A704")]
		[Address(RVA = "0x20F8490", Offset = "0x20F8490", VA = "0x7BBC8F8490")]
		public List<MessageInfo> GetChannelMessageList(EChannel.ChannelType type, ulong id)
		{
			return null;
		}

		// Token: 0x0600A705 RID: 42757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A705")]
		[Address(RVA = "0x20FAAE8", Offset = "0x20FAAE8", VA = "0x7BBC8FAAE8")]
		public MessageInfo GetLatestMessage(EChannel.ChannelType type, ulong id)
		{
			return null;
		}

		// Token: 0x0600A706 RID: 42758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A706")]
		[Address(RVA = "0x20FABC8", Offset = "0x20FABC8", VA = "0x7BBC8FABC8")]
		public void RecvNewMessageList(TextMsgReq info)
		{
		}

		// Token: 0x0600A707 RID: 42759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A707")]
		[Address(RVA = "0x20FBA34", Offset = "0x20FBA34", VA = "0x7BBC8FBA34")]
		public void SetWhisperUnread(ulong whisperID, bool hasUnreadTip)
		{
		}

		// Token: 0x0600A708 RID: 42760 RVA: 0x0002CF40 File Offset: 0x0002B140
		[Token(Token = "0x600A708")]
		[Address(RVA = "0x20FC6F0", Offset = "0x20FC6F0", VA = "0x7BBC8FC6F0")]
		public int GetWhisperUnread(ulong whisperID)
		{
			return 0;
		}

		// Token: 0x0600A709 RID: 42761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A709")]
		[Address(RVA = "0x20FC7A0", Offset = "0x20FC7A0", VA = "0x7BBC8FC7A0")]
		public void ResendMessage(MessageInfo resendInfo)
		{
		}

		// Token: 0x0600A70A RID: 42762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A70A")]
		[Address(RVA = "0x20FBBEC", Offset = "0x20FBBEC", VA = "0x7BBC8FBBEC")]
		public void AddNewMessageToList(EChannel.ChannelType type, ulong id, MessageInfo info)
		{
		}

		// Token: 0x0600A70B RID: 42763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A70B")]
		[Address(RVA = "0x20FC844", Offset = "0x20FC844", VA = "0x7BBC8FC844")]
		public void AddNewGroupRecuitMessage(MessageInfo info)
		{
		}

		// Token: 0x0600A70C RID: 42764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A70C")]
		[Address(RVA = "0x20FCF30", Offset = "0x20FCF30", VA = "0x7BBC8FCF30")]
		public void RemoveGroupRecruitMessage(ulong senderid)
		{
		}

		// Token: 0x0600A70D RID: 42765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A70D")]
		[Address(RVA = "0x20FCCE4", Offset = "0x20FCCE4", VA = "0x7BBC8FCCE4")]
		public List<MessageInfo> GetSortedGroupRecruitMessageList()
		{
			return null;
		}

		// Token: 0x0600A70E RID: 42766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A70E")]
		[Address(RVA = "0x20FCFDC", Offset = "0x20FCFDC", VA = "0x7BBC8FCFDC")]
		public void JoinRecruit(MessageInfo recruitData)
		{
		}

		// Token: 0x0600A70F RID: 42767 RVA: 0x0002CF58 File Offset: 0x0002B158
		[Token(Token = "0x600A70F")]
		[Address(RVA = "0x20FDF1C", Offset = "0x20FDF1C", VA = "0x7BBC8FDF1C")]
		private EGroup.InviteChannelType GetInviteChannel(EChannel.ChannelType type)
		{
			return EGroup.InviteChannelType.InviteChannelType_PLAYER;
		}

		// Token: 0x0600A710 RID: 42768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A710")]
		[Address(RVA = "0x20FE168", Offset = "0x20FE168", VA = "0x7BBC8FE168")]
		public void RemoveQuickAddFriendMessageInfo(EChannel.ChannelType type, ulong id, ulong senderId)
		{
		}

		// Token: 0x0600A711 RID: 42769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A711")]
		[Address(RVA = "0x20FE3F8", Offset = "0x20FE3F8", VA = "0x7BBC8FE3F8")]
		public void SendEventLog()
		{
		}

		// Token: 0x0600A712 RID: 42770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A712")]
		[Address(RVA = "0x20FE54C", Offset = "0x20FE54C", VA = "0x7BBC8FE54C")]
		public string RemoveColorAttribute(string content)
		{
			return null;
		}

		// Token: 0x0600A713 RID: 42771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A713")]
		[Address(RVA = "0x20FE760", Offset = "0x20FE760", VA = "0x7BBC8FE760")]
		public void AddToBlockList(ulong userid, string name)
		{
		}

		// Token: 0x0600A714 RID: 42772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A714")]
		[Address(RVA = "0x20FED2C", Offset = "0x20FED2C", VA = "0x7BBC8FED2C")]
		public void DeleteFromBlockList(ulong userid)
		{
		}

		// Token: 0x0600A715 RID: 42773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A715")]
		[Address(RVA = "0x20FEAF8", Offset = "0x20FEAF8", VA = "0x7BBC8FEAF8")]
		private void SaveBlockList()
		{
		}

		// Token: 0x0600A716 RID: 42774 RVA: 0x0002CF70 File Offset: 0x0002B170
		[Token(Token = "0x600A716")]
		[Address(RVA = "0x20FB970", Offset = "0x20FB970", VA = "0x7BBC8FB970")]
		public bool IsBlocked(ulong userid)
		{
			return default(bool);
		}

		// Token: 0x0600A717 RID: 42775 RVA: 0x0002CF88 File Offset: 0x0002B188
		[Token(Token = "0x600A717")]
		[Address(RVA = "0x20FAA54", Offset = "0x20FAA54", VA = "0x7BBC8FAA54")]
		private bool IsWorldTimesLimit(EChannel.MsgType msgType)
		{
			return default(bool);
		}

		// Token: 0x0600A718 RID: 42776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A718")]
		[Address(RVA = "0x20FEE18", Offset = "0x20FEE18", VA = "0x7BBC8FEE18")]
		public void SetWorldChatLeftTimes(uint leftTalk, uint leftFast)
		{
		}

		// Token: 0x0600A719 RID: 42777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A719")]
		[Address(RVA = "0x20FEE98", Offset = "0x20FEE98", VA = "0x7BBC8FEE98")]
		public void SetWorldChatMaxTimes(uint talkTimes, uint fastTimes)
		{
		}

		// Token: 0x0600A71A RID: 42778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A71A")]
		[Address(RVA = "0x20FEEA0", Offset = "0x20FEEA0", VA = "0x7BBC8FEEA0")]
		public void UpdateWorldChatLimit()
		{
		}

		// Token: 0x0600A71B RID: 42779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A71B")]
		[Address(RVA = "0x20FEFCC", Offset = "0x20FEFCC", VA = "0x7BBC8FEFCC")]
		public void SetWorldEnableCustom(bool enable)
		{
		}

		// Token: 0x0600A71C RID: 42780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A71C")]
		[Address(RVA = "0x20FEFD8", Offset = "0x20FEFD8", VA = "0x7BBC8FEFD8")]
		public void BuySticker(uint itemID)
		{
		}

		// Token: 0x0600A71D RID: 42781 RVA: 0x0002CFA0 File Offset: 0x0002B1A0
		[Token(Token = "0x600A71D")]
		[Address(RVA = "0x20FCB7C", Offset = "0x20FCB7C", VA = "0x7BBC8FCB7C")]
		public bool IsRecruitOverSelfRank(uint gameMode, uint reqRank)
		{
			return default(bool);
		}

		// Token: 0x0600A71E RID: 42782 RVA: 0x0002CFB8 File Offset: 0x0002B1B8
		[Token(Token = "0x600A71E")]
		[Address(RVA = "0x20FF254", Offset = "0x20FF254", VA = "0x7BBC8FF254")]
		public bool EnableReportChat()
		{
			return default(bool);
		}

		// Token: 0x0600A71F RID: 42783 RVA: 0x0002CFD0 File Offset: 0x0002B1D0
		[Token(Token = "0x600A71F")]
		[Address(RVA = "0x20FAA74", Offset = "0x20FAA74", VA = "0x7BBC8FAA74")]
		public bool IsMuted()
		{
			return default(bool);
		}

		// Token: 0x0600A720 RID: 42784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A720")]
		[Address(RVA = "0x20FF2EC", Offset = "0x20FF2EC", VA = "0x7BBC8FF2EC")]
		public void SetMutedTime(long timeToLive)
		{
		}

		// Token: 0x0600A721 RID: 42785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A721")]
		[Address(RVA = "0x20FF370", Offset = "0x20FF370", VA = "0x7BBC8FF370")]
		public void ReportChat(MessageInfo reportedMsg, uint reason)
		{
		}

		// Token: 0x0600A722 RID: 42786 RVA: 0x0002CFE8 File Offset: 0x0002B1E8
		[Token(Token = "0x600A722")]
		[Address(RVA = "0x20F8AFC", Offset = "0x20F8AFC", VA = "0x7BBC8F8AFC")]
		public static ETipsType ChannelType2TipsType(EChannel.ChannelType cType)
		{
			return ETipsType.None;
		}

		// Token: 0x0600A723 RID: 42787 RVA: 0x0002D000 File Offset: 0x0002B200
		[Token(Token = "0x600A723")]
		[Address(RVA = "0x20FF4D0", Offset = "0x20FF4D0", VA = "0x7BBC8FF4D0")]
		public static EChannel.ChannelType TipsType2ChannelType(ETipsType eType)
		{
			return EChannel.ChannelType.ChannelType_GROUP;
		}

		// Token: 0x0600A724 RID: 42788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A724")]
		[Address(RVA = "0x20FF4F4", Offset = "0x20FF4F4", VA = "0x7BBC8FF4F4")]
		public void SetIntenRecruitInfo(bool world, bool clan, uint rankLimit, string groupTag)
		{
		}

		// Token: 0x0600A725 RID: 42789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A725")]
		[Address(RVA = "0x20F78D8", Offset = "0x20F78D8", VA = "0x7BBC8F78D8")]
		public void ClearIntenRecruitInfo()
		{
		}

		// Token: 0x0600A726 RID: 42790 RVA: 0x0002D018 File Offset: 0x0002B218
		[Token(Token = "0x600A726")]
		[Address(RVA = "0x20FF5E8", Offset = "0x20FF5E8", VA = "0x7BBC8FF5E8")]
		public bool SendIntentRecruit()
		{
			return default(bool);
		}

		// Token: 0x0600A727 RID: 42791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A727")]
		[Address(RVA = "0x20FFCF4", Offset = "0x20FFCF4", VA = "0x7BBC8FFCF4")]
		public UIModelChat()
		{
		}

		// Token: 0x0400AC8A RID: 44170
		[Token(Token = "0x400AC8A")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<ChatChannelInfo, List<MessageInfo>> m_ChatDictionary;

		// Token: 0x0400AC8B RID: 44171
		[Token(Token = "0x400AC8B")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<ChatChannelInfo, uint> m_RecvMessageNumCache;

		// Token: 0x0400AC8C RID: 44172
		[Token(Token = "0x400AC8C")]
		[FieldOffset(Offset = "0x28")]
		private List<ChatChannelInfo> m_ChannelInfoList;

		// Token: 0x0400AC8D RID: 44173
		[Token(Token = "0x400AC8D")]
		[FieldOffset(Offset = "0x30")]
		private List<MessageInfo> m_SendingMessages;

		// Token: 0x0400AC8E RID: 44174
		[Token(Token = "0x400AC8E")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<ulong, MessageInfo> m_GroupRecruitMessagesDic;

		// Token: 0x0400AC8F RID: 44175
		[Token(Token = "0x400AC8F")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<ulong, int> m_UnreadWhisperID;

		// Token: 0x0400AC90 RID: 44176
		[Token(Token = "0x400AC90")]
		[FieldOffset(Offset = "0x48")]
		private EventLogger.EventChat m_ChatEvent;

		// Token: 0x0400AC91 RID: 44177
		[Token(Token = "0x400AC91")]
		[FieldOffset(Offset = "0x50")]
		private MessageInfo m_LatestMessage;

		// Token: 0x0400AC92 RID: 44178
		[Token(Token = "0x400AC92")]
		[FieldOffset(Offset = "0x58")]
		private ulong m_LastSendTimestamp;

		// Token: 0x0400AC93 RID: 44179
		[Token(Token = "0x400AC93")]
		[FieldOffset(Offset = "0x60")]
		private ulong m_LastWorldSendTs;

		// Token: 0x0400AC94 RID: 44180
		[Token(Token = "0x400AC94")]
		[FieldOffset(Offset = "0x68")]
		private ulong m_LastJoinWorldChannelTimeStamp;

		// Token: 0x0400AC95 RID: 44181
		[Token(Token = "0x400AC95")]
		[FieldOffset(Offset = "0x0")]
		private static ulong JOIN_WORLD_CHANNEL_CD;

		// Token: 0x0400AC96 RID: 44182
		[Token(Token = "0x400AC96")]
		[FieldOffset(Offset = "0x70")]
		private uint m_LeftWorldTalkTimes;

		// Token: 0x0400AC97 RID: 44183
		[Token(Token = "0x400AC97")]
		[FieldOffset(Offset = "0x74")]
		private uint m_LeftWorldFastTimes;

		// Token: 0x0400AC98 RID: 44184
		[Token(Token = "0x400AC98")]
		[FieldOffset(Offset = "0x78")]
		private uint m_WorldTalkMax;

		// Token: 0x0400AC99 RID: 44185
		[Token(Token = "0x400AC99")]
		[FieldOffset(Offset = "0x7C")]
		private uint m_WorldFastMax;

		// Token: 0x0400AC9A RID: 44186
		[Token(Token = "0x400AC9A")]
		[FieldOffset(Offset = "0x80")]
		private ulong m_LastUpdateWorldTimesLimitTs;

		// Token: 0x0400AC9B RID: 44187
		[Token(Token = "0x400AC9B")]
		private const int m_ServerUpdateHour = 4;

		// Token: 0x0400AC9C RID: 44188
		[Token(Token = "0x400AC9C")]
		[FieldOffset(Offset = "0x88")]
		private bool m_EnableWorldCustomTalk;

		// Token: 0x0400AC9D RID: 44189
		[Token(Token = "0x400AC9D")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FEAC", Offset = "0x112FEAC")]
		private ulong <MutedTimeStamp>k__BackingField;

		// Token: 0x0400AC9E RID: 44190
		[Token(Token = "0x400AC9E")]
		private const string ChatReportTimesKey = "ChatReportTimesKey";

		// Token: 0x0400AC9F RID: 44191
		[Token(Token = "0x400AC9F")]
		[FieldOffset(Offset = "0x98")]
		public bool m_HasRequestClanMemberList;

		// Token: 0x0400ACA0 RID: 44192
		[Token(Token = "0x400ACA0")]
		[FieldOffset(Offset = "0xA0")]
		private List<int> m_GroupInviteTimeOutMessages;

		// Token: 0x0400ACA1 RID: 44193
		[Token(Token = "0x400ACA1")]
		[FieldOffset(Offset = "0xA8")]
		private List<uint> m_GroupInviteCallIDs;

		// Token: 0x0400ACA2 RID: 44194
		[Token(Token = "0x400ACA2")]
		[FieldOffset(Offset = "0xB0")]
		public string QuickAddFriendNickName;

		// Token: 0x0400ACA3 RID: 44195
		[Token(Token = "0x400ACA3")]
		[FieldOffset(Offset = "0xB8")]
		public ulong QuickAddFriendId;

		// Token: 0x0400ACA4 RID: 44196
		[Token(Token = "0x400ACA4")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<uint, uint> m_NumberOfContinuousChats;

		// Token: 0x0400ACA5 RID: 44197
		[Token(Token = "0x400ACA5")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<uint, ulong> m_IdOfContinuousChats;

		// Token: 0x0400ACA6 RID: 44198
		[Token(Token = "0x400ACA6")]
		[FieldOffset(Offset = "0xD0")]
		private Dictionary<uint, bool> m_HasLocalPlayerTalked;

		// Token: 0x0400ACA7 RID: 44199
		[Token(Token = "0x400ACA7")]
		[FieldOffset(Offset = "0xD8")]
		private List<ulong> m_QuickAddFriendTipId;

		// Token: 0x0400ACA8 RID: 44200
		[Token(Token = "0x400ACA8")]
		[FieldOffset(Offset = "0xE0")]
		private List<ChatBlockUserInfo> m_ChatBlockList;

		// Token: 0x0400ACA9 RID: 44201
		[Token(Token = "0x400ACA9")]
		[FieldOffset(Offset = "0xE8")]
		private Dictionary<EChannel.ChannelType, int> m_ChannelSortOrder;

		// Token: 0x0400ACAA RID: 44202
		[Token(Token = "0x400ACAA")]
		private const int MAX_HISTORY_MESSAGE_LENGTH = 200;

		// Token: 0x0400ACAB RID: 44203
		[Token(Token = "0x400ACAB")]
		private const int MAX_HISTORY_RECRUIT_MESSAGE_LENGTH = 50;

		// Token: 0x0400ACAC RID: 44204
		[Token(Token = "0x400ACAC")]
		private const int MAX_WHISPER_COUNT = 10;

		// Token: 0x0400ACAD RID: 44205
		[Token(Token = "0x400ACAD")]
		private const int STABLE_CHANNEL_COUNT = 3;

		// Token: 0x0400ACAE RID: 44206
		[Token(Token = "0x400ACAE")]
		public const int SEND_MESSAGE_CDTIME = 2;

		// Token: 0x0400ACAF RID: 44207
		[Token(Token = "0x400ACAF")]
		public const uint PropID_UpdateMessageList = 1U;

		// Token: 0x0400ACB0 RID: 44208
		[Token(Token = "0x400ACB0")]
		public const uint PropID_UpdateProfileInfo = 2U;

		// Token: 0x0400ACB1 RID: 44209
		[Token(Token = "0x400ACB1")]
		public const uint PropID_JoinOrLeaveRoom = 4U;

		// Token: 0x0400ACB2 RID: 44210
		[Token(Token = "0x400ACB2")]
		public const uint PropID_RefreshWhisperList = 8U;

		// Token: 0x0400ACB3 RID: 44211
		[Token(Token = "0x400ACB3")]
		public const uint PropID_UpdateStickerList = 16U;

		// Token: 0x0400ACB4 RID: 44212
		[Token(Token = "0x400ACB4")]
		public const uint SPEAKER_ITEM_ID = 800000401U;

		// Token: 0x0400ACB5 RID: 44213
		[Token(Token = "0x400ACB5")]
		public const string FAST_MSG_CLAN_TYPENAME = "clan";

		// Token: 0x0400ACB6 RID: 44214
		[Token(Token = "0x400ACB6")]
		public const string FAST_MSG_GROUP_TYPENAME = "group";

		// Token: 0x0400ACB7 RID: 44215
		[Token(Token = "0x400ACB7")]
		public const string FAST_MSG_BIGEVENT_TYPENAME = "BigEventMsg";

		// Token: 0x0400ACB8 RID: 44216
		[Token(Token = "0x400ACB8")]
		public const string FAST_MSG_CHAMPIONSHIPTEAM_TYPENAME = "championshipTeam";

		// Token: 0x0400ACB9 RID: 44217
		[Token(Token = "0x400ACB9")]
		[FieldOffset(Offset = "0xF0")]
		private UIModelChat.IntentRecruitInfo intentRecruitInfo;

		// Token: 0x02001DDB RID: 7643
		[Token(Token = "0x2001DDB")]
		public class IntentRecruitInfo
		{
			// Token: 0x0600A729 RID: 42793 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A729")]
			[Address(RVA = "0x20FF58C", Offset = "0x20FF58C", VA = "0x7BBC8FF58C")]
			public IntentRecruitInfo(bool world, bool clan, uint rankLimit, string groupTag)
			{
			}

			// Token: 0x0400ACBA RID: 44218
			[Token(Token = "0x400ACBA")]
			[FieldOffset(Offset = "0x10")]
			public bool m_ToWorld;

			// Token: 0x0400ACBB RID: 44219
			[Token(Token = "0x400ACBB")]
			[FieldOffset(Offset = "0x11")]
			public bool m_ToClan;

			// Token: 0x0400ACBC RID: 44220
			[Token(Token = "0x400ACBC")]
			[FieldOffset(Offset = "0x14")]
			public uint m_RankLimit;

			// Token: 0x0400ACBD RID: 44221
			[Token(Token = "0x400ACBD")]
			[FieldOffset(Offset = "0x18")]
			public string m_GroupTag;
		}

		// Token: 0x02001DDC RID: 7644
		[Token(Token = "0x2001DDC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC184", Offset = "0x10FC184")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A72B RID: 42795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A72B")]
			[Address(RVA = "0x21001E4", Offset = "0x21001E4", VA = "0x7BBC9001E4")]
			public <>c()
			{
			}

			// Token: 0x0600A72C RID: 42796 RVA: 0x0002D030 File Offset: 0x0002B230
			[Token(Token = "0x600A72C")]
			[Address(RVA = "0x21001EC", Offset = "0x21001EC", VA = "0x7BBC9001EC")]
			internal bool <AddWhisper>b__74_0(ChatChannelInfo x)
			{
				return default(bool);
			}

			// Token: 0x0600A72D RID: 42797 RVA: 0x0002D048 File Offset: 0x0002B248
			[Token(Token = "0x600A72D")]
			[Address(RVA = "0x2100234", Offset = "0x2100234", VA = "0x7BBC900234")]
			internal int <GetSortedGroupRecruitMessageList>b__98_0(MessageInfo x, MessageInfo y)
			{
				return 0;
			}

			// Token: 0x0400ACBE RID: 44222
			[Token(Token = "0x400ACBE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIModelChat.<>c <>9;

			// Token: 0x0400ACBF RID: 44223
			[Token(Token = "0x400ACBF")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<ChatChannelInfo> <>9__74_0;

			// Token: 0x0400ACC0 RID: 44224
			[Token(Token = "0x400ACC0")]
			[FieldOffset(Offset = "0x10")]
			public static Comparison<MessageInfo> <>9__98_0;
		}

		// Token: 0x02001DDD RID: 7645
		[Token(Token = "0x2001DDD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC194", Offset = "0x10FC194")]
		private sealed class <>c__DisplayClass75_0
		{
			// Token: 0x0600A72E RID: 42798 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A72E")]
			[Address(RVA = "0x20F814C", Offset = "0x20F814C", VA = "0x7BBC8F814C")]
			public <>c__DisplayClass75_0()
			{
			}

			// Token: 0x0600A72F RID: 42799 RVA: 0x0002D060 File Offset: 0x0002B260
			[Token(Token = "0x600A72F")]
			[Address(RVA = "0x2100408", Offset = "0x2100408", VA = "0x7BBC900408")]
			internal bool <GetChannelInfo>b__0(ChatChannelInfo x)
			{
				return default(bool);
			}

			// Token: 0x0600A730 RID: 42800 RVA: 0x0002D078 File Offset: 0x0002B278
			[Token(Token = "0x600A730")]
			[Address(RVA = "0x2100444", Offset = "0x2100444", VA = "0x7BBC900444")]
			internal bool <GetChannelInfo>b__1(ChatChannelInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400ACC1 RID: 44225
			[Token(Token = "0x400ACC1")]
			[FieldOffset(Offset = "0x10")]
			public EChannel.ChannelType type;

			// Token: 0x0400ACC2 RID: 44226
			[Token(Token = "0x400ACC2")]
			[FieldOffset(Offset = "0x18")]
			public ulong id;
		}

		// Token: 0x02001DDE RID: 7646
		[Token(Token = "0x2001DDE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC1A4", Offset = "0x10FC1A4")]
		private sealed class <>c__DisplayClass101_0
		{
			// Token: 0x0600A731 RID: 42801 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A731")]
			[Address(RVA = "0x20FE3F0", Offset = "0x20FE3F0", VA = "0x7BBC8FE3F0")]
			public <>c__DisplayClass101_0()
			{
			}

			// Token: 0x0600A732 RID: 42802 RVA: 0x0002D090 File Offset: 0x0002B290
			[Token(Token = "0x600A732")]
			[Address(RVA = "0x2100298", Offset = "0x2100298", VA = "0x7BBC900298")]
			internal bool <RemoveQuickAddFriendMessageInfo>b__0(MessageInfo x)
			{
				return default(bool);
			}

			// Token: 0x0400ACC3 RID: 44227
			[Token(Token = "0x400ACC3")]
			[FieldOffset(Offset = "0x10")]
			public ulong senderId;

			// Token: 0x0400ACC4 RID: 44228
			[Token(Token = "0x400ACC4")]
			[FieldOffset(Offset = "0x18")]
			public ulong id;

			// Token: 0x0400ACC5 RID: 44229
			[Token(Token = "0x400ACC5")]
			[FieldOffset(Offset = "0x20")]
			public EChannel.ChannelType type;
		}

		// Token: 0x02001DDF RID: 7647
		[Token(Token = "0x2001DDF")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FC1B4", Offset = "0x10FC1B4")]
		private sealed class <>c__DisplayClass113_0
		{
			// Token: 0x0600A733 RID: 42803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A733")]
			[Address(RVA = "0x20FF24C", Offset = "0x20FF24C", VA = "0x7BBC8FF24C")]
			public <>c__DisplayClass113_0()
			{
			}

			// Token: 0x0600A734 RID: 42804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A734")]
			[Address(RVA = "0x2100308", Offset = "0x2100308", VA = "0x7BBC900308")]
			internal void <BuySticker>b__0(HttpErrorCode errorcode, object obj)
			{
			}

			// Token: 0x0400ACC6 RID: 44230
			[Token(Token = "0x400ACC6")]
			[FieldOffset(Offset = "0x10")]
			public UIModelChat <>4__this;

			// Token: 0x0400ACC7 RID: 44231
			[Token(Token = "0x400ACC7")]
			[FieldOffset(Offset = "0x18")]
			public uint itemID;
		}
	}
}
