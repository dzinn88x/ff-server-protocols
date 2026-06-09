using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW
{
	// Token: 0x02001C65 RID: 7269
	[Token(Token = "0x2001C65")]
	public class BaseProfileInfo
	{
		// Token: 0x06009E6B RID: 40555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E6B")]
		[Address(RVA = "0x21D3DDC", Offset = "0x21D3DDC", VA = "0x7BBC9D3DDC")]
		public static implicit operator BaseProfileInfo(FriendAccountInfo friendInfo)
		{
			return null;
		}

		// Token: 0x06009E6C RID: 40556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E6C")]
		[Address(RVA = "0x21D4174", Offset = "0x21D4174", VA = "0x7BBC9D4174")]
		public static implicit operator BaseProfileInfo(AccountInfoBasic basicInfo)
		{
			return null;
		}

		// Token: 0x06009E6D RID: 40557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E6D")]
		[Address(RVA = "0x21D4434", Offset = "0x21D4434", VA = "0x7BBC9D4434")]
		public static implicit operator BaseProfileInfo(GroupMemberInfo basicInfo)
		{
			return null;
		}

		// Token: 0x06009E6E RID: 40558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E6E")]
		[Address(RVA = "0x21D46F4", Offset = "0x21D46F4", VA = "0x7BBC9D46F4")]
		public static implicit operator BaseProfileInfo(RoomPlayerInfo data)
		{
			return null;
		}

		// Token: 0x06009E6F RID: 40559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E6F")]
		[Address(RVA = "0x21D48C0", Offset = "0x21D48C0", VA = "0x7BBC9D48C0")]
		public BaseProfileInfo(LoginRes loginInfo)
		{
		}

		// Token: 0x06009E70 RID: 40560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E70")]
		[Address(RVA = "0x21D4B30", Offset = "0x21D4B30", VA = "0x7BBC9D4B30")]
		public BaseProfileInfo(TeammateStats data)
		{
		}

		// Token: 0x06009E71 RID: 40561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E71")]
		[Address(RVA = "0x21D4DFC", Offset = "0x21D4DFC", VA = "0x7BBC9D4DFC")]
		public BaseProfileInfo(MatchStats data)
		{
		}

		// Token: 0x06009E72 RID: 40562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E72")]
		[Address(RVA = "0x21D5040", Offset = "0x21D5040", VA = "0x7BBC9D5040")]
		public static implicit operator BaseProfileInfo(TextMsgReq chatMsg)
		{
			return null;
		}

		// Token: 0x06009E73 RID: 40563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E73")]
		[Address(RVA = "0x21D4020", Offset = "0x21D4020", VA = "0x7BBC9D4020")]
		public BaseProfileInfo()
		{
		}

		// Token: 0x06009E74 RID: 40564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E74")]
		[Address(RVA = "0x21D5250", Offset = "0x21D5250", VA = "0x7BBC9D5250")]
		public void ResetMyWeapons()
		{
		}

		// Token: 0x06009E75 RID: 40565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E75")]
		[Address(RVA = "0x21D53E8", Offset = "0x21D53E8", VA = "0x7BBC9D53E8")]
		public void ResetMyVehicleSkins()
		{
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E76")]
		[Address(RVA = "0x21D5580", Offset = "0x21D5580", VA = "0x7BBC9D5580")]
		public void RefreshMyShows(uint[] arr)
		{
		}

		// Token: 0x06009E77 RID: 40567 RVA: 0x000296D0 File Offset: 0x000278D0
		[Token(Token = "0x6009E77")]
		[Address(RVA = "0x21D56D0", Offset = "0x21D56D0", VA = "0x7BBC9D56D0")]
		public uint GetShowWeapon()
		{
			return 0U;
		}

		// Token: 0x06009E78 RID: 40568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E78")]
		[Address(RVA = "0x21D574C", Offset = "0x21D574C", VA = "0x7BBC9D574C")]
		public void RefreshEmoteSlots(ChoosedEmotes _choosedEmote)
		{
		}

		// Token: 0x06009E79 RID: 40569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E79")]
		[Address(RVA = "0x21D58FC", Offset = "0x21D58FC", VA = "0x7BBC9D58FC")]
		public void ChangeEmoteSlots(CSGetSelectedItemsRes res)
		{
		}

		// Token: 0x06009E7A RID: 40570 RVA: 0x000296E8 File Offset: 0x000278E8
		[Token(Token = "0x6009E7A")]
		[Address(RVA = "0x21D5970", Offset = "0x21D5970", VA = "0x7BBC9D5970")]
		public uint GetUnEquipEmoteSlotIndex(uint _id)
		{
			return 0U;
		}

		// Token: 0x06009E7B RID: 40571 RVA: 0x00029700 File Offset: 0x00027900
		[Token(Token = "0x6009E7B")]
		[Address(RVA = "0x21D5A2C", Offset = "0x21D5A2C", VA = "0x7BBC9D5A2C")]
		public uint GetEmoteSlotIndex(uint id)
		{
			return 0U;
		}

		// Token: 0x06009E7C RID: 40572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E7C")]
		[Address(RVA = "0x21D5B20", Offset = "0x21D5B20", VA = "0x7BBC9D5B20")]
		public void ResetAllSlots()
		{
		}

		// Token: 0x06009E7D RID: 40573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E7D")]
		[Address(RVA = "0x21D5B50", Offset = "0x21D5B50", VA = "0x7BBC9D5B50")]
		public void RefreshSlots(uint[] slots)
		{
		}

		// Token: 0x06009E7E RID: 40574 RVA: 0x00029718 File Offset: 0x00027918
		[Token(Token = "0x6009E7E")]
		[Address(RVA = "0x21D5E04", Offset = "0x21D5E04", VA = "0x7BBC9D5E04")]
		public uint EmoteEquippedCount()
		{
			return 0U;
		}

		// Token: 0x06009E7F RID: 40575 RVA: 0x00029730 File Offset: 0x00027930
		[Token(Token = "0x6009E7F")]
		[Address(RVA = "0x21D5F48", Offset = "0x21D5F48", VA = "0x7BBC9D5F48")]
		public bool hasEquippedEmote(uint emoteID)
		{
			return default(bool);
		}

		// Token: 0x0400A4B4 RID: 42164
		[Token(Token = "0x400A4B4")]
		[FieldOffset(Offset = "0x10")]
		public ulong AccountID;

		// Token: 0x0400A4B5 RID: 42165
		[Token(Token = "0x400A4B5")]
		[FieldOffset(Offset = "0x18")]
		public string Region;

		// Token: 0x0400A4B6 RID: 42166
		[Token(Token = "0x400A4B6")]
		[FieldOffset(Offset = "0x20")]
		public uint Level;

		// Token: 0x0400A4B7 RID: 42167
		[Token(Token = "0x400A4B7")]
		[FieldOffset(Offset = "0x28")]
		public string NickName;

		// Token: 0x0400A4B8 RID: 42168
		[Token(Token = "0x400A4B8")]
		[FieldOffset(Offset = "0x30")]
		public string OnlineState;

		// Token: 0x0400A4B9 RID: 42169
		[Token(Token = "0x400A4B9")]
		[FieldOffset(Offset = "0x38")]
		public string PortraitUrl;

		// Token: 0x0400A4BA RID: 42170
		[Token(Token = "0x400A4BA")]
		[FieldOffset(Offset = "0x40")]
		public string PlatformIcon;

		// Token: 0x0400A4BB RID: 42171
		[Token(Token = "0x400A4BB")]
		[FieldOffset(Offset = "0x48")]
		public string ExternalName;

		// Token: 0x0400A4BC RID: 42172
		[Token(Token = "0x400A4BC")]
		[FieldOffset(Offset = "0x50")]
		public string GenderIcon;

		// Token: 0x0400A4BD RID: 42173
		[Token(Token = "0x400A4BD")]
		[FieldOffset(Offset = "0x58")]
		public string ClanName;

		// Token: 0x0400A4BE RID: 42174
		[Token(Token = "0x400A4BE")]
		[FieldOffset(Offset = "0x60")]
		public uint Banner;

		// Token: 0x0400A4BF RID: 42175
		[Token(Token = "0x400A4BF")]
		[FieldOffset(Offset = "0x64")]
		public uint HeadPic;

		// Token: 0x0400A4C0 RID: 42176
		[Token(Token = "0x400A4C0")]
		[FieldOffset(Offset = "0x68")]
		public int Rank;

		// Token: 0x0400A4C1 RID: 42177
		[Token(Token = "0x400A4C1")]
		[FieldOffset(Offset = "0x6C")]
		public int RankPoint;

		// Token: 0x0400A4C2 RID: 42178
		[Token(Token = "0x400A4C2")]
		[FieldOffset(Offset = "0x70")]
		public int CSRank;

		// Token: 0x0400A4C3 RID: 42179
		[Token(Token = "0x400A4C3")]
		[FieldOffset(Offset = "0x74")]
		public int CSRankPoint;

		// Token: 0x0400A4C4 RID: 42180
		[Token(Token = "0x400A4C4")]
		[FieldOffset(Offset = "0x78")]
		public bool is_cs_ranking_ban;

		// Token: 0x0400A4C5 RID: 42181
		[Token(Token = "0x400A4C5")]
		[FieldOffset(Offset = "0x80")]
		public long Update_time;

		// Token: 0x0400A4C6 RID: 42182
		[Token(Token = "0x400A4C6")]
		[FieldOffset(Offset = "0x88")]
		public uint skinColor;

		// Token: 0x0400A4C7 RID: 42183
		[Token(Token = "0x400A4C7")]
		[FieldOffset(Offset = "0x8C")]
		public uint AvatarID;

		// Token: 0x0400A4C8 RID: 42184
		[Token(Token = "0x400A4C8")]
		[FieldOffset(Offset = "0x90")]
		public List<uint> cloth;

		// Token: 0x0400A4C9 RID: 42185
		[Token(Token = "0x400A4C9")]
		[FieldOffset(Offset = "0x98")]
		public proto.EPresence.AccountPresence OnlineStatus;

		// Token: 0x0400A4CA RID: 42186
		[Token(Token = "0x400A4CA")]
		[FieldOffset(Offset = "0x9C")]
		public uint LootBox;

		// Token: 0x0400A4CB RID: 42187
		[Token(Token = "0x400A4CB")]
		[FieldOffset(Offset = "0xA0")]
		public uint BackPack;

		// Token: 0x0400A4CC RID: 42188
		[Token(Token = "0x400A4CC")]
		[FieldOffset(Offset = "0xA4")]
		public uint Parachute;

		// Token: 0x0400A4CD RID: 42189
		[Token(Token = "0x400A4CD")]
		[FieldOffset(Offset = "0xA8")]
		public uint Skyboard;

		// Token: 0x0400A4CE RID: 42190
		[Token(Token = "0x400A4CE")]
		[FieldOffset(Offset = "0xAC")]
		public uint Flight;

		// Token: 0x0400A4CF RID: 42191
		[Token(Token = "0x400A4CF")]
		[FieldOffset(Offset = "0xB0")]
		public uint Pin;

		// Token: 0x0400A4D0 RID: 42192
		[Token(Token = "0x400A4D0")]
		[FieldOffset(Offset = "0xB8")]
		public Dictionary<uint, uint> Weapons;

		// Token: 0x0400A4D1 RID: 42193
		[Token(Token = "0x400A4D1")]
		[FieldOffset(Offset = "0xC0")]
		public Dictionary<uint, uint> VehicleSkins;

		// Token: 0x0400A4D2 RID: 42194
		[Token(Token = "0x400A4D2")]
		[FieldOffset(Offset = "0xC8")]
		public Dictionary<uint, uint> EmoteSlots;

		// Token: 0x0400A4D3 RID: 42195
		[Token(Token = "0x400A4D3")]
		[FieldOffset(Offset = "0xD0")]
		public Dictionary<uint, uint> Shows;

		// Token: 0x0400A4D4 RID: 42196
		[Token(Token = "0x400A4D4")]
		[FieldOffset(Offset = "0xD8")]
		public bool HasElitePass;

		// Token: 0x0400A4D5 RID: 42197
		[Token(Token = "0x400A4D5")]
		[FieldOffset(Offset = "0xDC")]
		public uint EPBadgeId;

		// Token: 0x0400A4D6 RID: 42198
		[Token(Token = "0x400A4D6")]
		[FieldOffset(Offset = "0xE0")]
		public uint EPBadgeCount;

		// Token: 0x0400A4D7 RID: 42199
		[Token(Token = "0x400A4D7")]
		[FieldOffset(Offset = "0xE4")]
		public bool ShowCallsignRank;

		// Token: 0x0400A4D8 RID: 42200
		[Token(Token = "0x400A4D8")]
		[FieldOffset(Offset = "0xE8")]
		public long LastLoginAt;

		// Token: 0x0400A4D9 RID: 42201
		[Token(Token = "0x400A4D9")]
		[FieldOffset(Offset = "0xF0")]
		public uint Role;

		// Token: 0x0400A4DA RID: 42202
		[Token(Token = "0x400A4DA")]
		[FieldOffset(Offset = "0xF8")]
		public ulong GroupId;

		// Token: 0x0400A4DB RID: 42203
		[Token(Token = "0x400A4DB")]
		[FieldOffset(Offset = "0x100")]
		public uint TrainingTokenCnt;
	}
}
