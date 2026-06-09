using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200134E RID: 4942
	[Token(Token = "0x200134E")]
	public class ActivityAwardItem : MonoBehaviour
	{
		// Token: 0x06004E84 RID: 20100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E84")]
		[Address(RVA = "0x1F9A01C", Offset = "0x1F9A01C", VA = "0x7BBC79A01C")]
		private void Awake()
		{
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E85")]
		[Address(RVA = "0x1F9A0A8", Offset = "0x1F9A0A8", VA = "0x7BBC79A0A8")]
		private void Start()
		{
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E86")]
		[Address(RVA = "0x1F9A0AC", Offset = "0x1F9A0AC", VA = "0x7BBC79A0AC")]
		private void Update()
		{
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E87")]
		[Address(RVA = "0x1F9A0B0", Offset = "0x1F9A0B0", VA = "0x7BBC79A0B0")]
		private void InitScaleMap()
		{
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06004E89 RID: 20105 RVA: 0x00017FA0 File Offset: 0x000161A0
		// (set) Token: 0x06004E88 RID: 20104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000865")]
		public int TargetBGWidth
		{
			[Token(Token = "0x6004E89")]
			[Address(RVA = "0x1F9A774", Offset = "0x1F9A774", VA = "0x7BBC79A774")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DEA8", Offset = "0x113DEA8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004E88")]
			[Address(RVA = "0x1F9A76C", Offset = "0x1F9A76C", VA = "0x7BBC79A76C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DE98", Offset = "0x113DE98")]
			private set
			{
			}
		}

		// Token: 0x06004E8A RID: 20106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E8A")]
		[Address(RVA = "0x1F9A77C", Offset = "0x1F9A77C", VA = "0x7BBC79A77C")]
		public void SetData(BaseItemInfo data)
		{
		}

		// Token: 0x06004E8B RID: 20107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E8B")]
		[Address(RVA = "0x1F9BCAC", Offset = "0x1F9BCAC", VA = "0x7BBC79BCAC")]
		public void UpdateCount()
		{
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E8C")]
		[Address(RVA = "0x1F9BA54", Offset = "0x1F9BA54", VA = "0x7BBC79BA54")]
		public string CalcCount(BaseItemInfo data)
		{
			return null;
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x00017FB8 File Offset: 0x000161B8
		[Token(Token = "0x6004E8D")]
		[Address(RVA = "0x1F9BD40", Offset = "0x1F9BD40", VA = "0x7BBC79BD40")]
		public int GetWitdh()
		{
			return 0;
		}

		// Token: 0x06004E8E RID: 20110 RVA: 0x00017FD0 File Offset: 0x000161D0
		[Token(Token = "0x6004E8E")]
		[Address(RVA = "0x1F9BD80", Offset = "0x1F9BD80", VA = "0x7BBC79BD80")]
		public int GetHeight()
		{
			return 0;
		}

		// Token: 0x06004E8F RID: 20111 RVA: 0x00017FE8 File Offset: 0x000161E8
		[Token(Token = "0x6004E8F")]
		[Address(RVA = "0x1F9B16C", Offset = "0x1F9B16C", VA = "0x7BBC79B16C")]
		private Vector2 GetIconScale(BaseItemInfo item)
		{
			return default(Vector2);
		}

		// Token: 0x06004E90 RID: 20112 RVA: 0x00018000 File Offset: 0x00016200
		[Token(Token = "0x6004E90")]
		[Address(RVA = "0x1F9B2E0", Offset = "0x1F9B2E0", VA = "0x7BBC79B2E0")]
		private float GetIconRotate(BaseItemInfo item)
		{
			return 0f;
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x00018018 File Offset: 0x00016218
		[Token(Token = "0x6004E91")]
		[Address(RVA = "0x1F9BDB0", Offset = "0x1F9BDB0", VA = "0x7BBC79BDB0")]
		private bool GetIconSpecialScale(CSSharedItemData itemData, out Vector2 scale)
		{
			return default(bool);
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x00018030 File Offset: 0x00016230
		[Token(Token = "0x6004E92")]
		[Address(RVA = "0x1F9BE40", Offset = "0x1F9BE40", VA = "0x7BBC79BE40")]
		private bool IsGrenade(uint id)
		{
			return default(bool);
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E93")]
		[Address(RVA = "0x1F9B588", Offset = "0x1F9B588", VA = "0x7BBC79B588")]
		private void AttachSpecialUI()
		{
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E94")]
		[Address(RVA = "0x1F9B33C", Offset = "0x1F9B33C", VA = "0x7BBC79B33C")]
		private void AttachBoxCollider()
		{
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E95")]
		[Address(RVA = "0x1F9BF40", Offset = "0x1F9BF40", VA = "0x7BBC79BF40")]
		public ActivityAwardItem()
		{
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E96")]
		[Address(RVA = "0x1F9C24C", Offset = "0x1F9C24C", VA = "0x7BBC79C24C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DEB8", Offset = "0x113DEB8")]
		private void <AttachBoxCollider>b__60_0(GameObject e)
		{
		}

		// Token: 0x04007591 RID: 30097
		[Token(Token = "0x4007591")]
		[FieldOffset(Offset = "0x18")]
		public UILabel Limitation;

		// Token: 0x04007592 RID: 30098
		[Token(Token = "0x4007592")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Count;

		// Token: 0x04007593 RID: 30099
		[Token(Token = "0x4007593")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Icon;

		// Token: 0x04007594 RID: 30100
		[Token(Token = "0x4007594")]
		[FieldOffset(Offset = "0x30")]
		public UISprite BG;

		// Token: 0x04007595 RID: 30101
		[Token(Token = "0x4007595")]
		[FieldOffset(Offset = "0x38")]
		public bool ShowOwnCount;

		// Token: 0x04007596 RID: 30102
		[Token(Token = "0x4007596")]
		[FieldOffset(Offset = "0x40")]
		public List<UIWidget> Quality;

		// Token: 0x04007597 RID: 30103
		[Token(Token = "0x4007597")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 ScaleTreasureBox;

		// Token: 0x04007598 RID: 30104
		[Token(Token = "0x4007598")]
		[FieldOffset(Offset = "0x50")]
		public Vector2 ScaleProps;

		// Token: 0x04007599 RID: 30105
		[Token(Token = "0x4007599")]
		[FieldOffset(Offset = "0x58")]
		public Vector2 ScaleRoomCard;

		// Token: 0x0400759A RID: 30106
		[Token(Token = "0x400759A")]
		[FieldOffset(Offset = "0x60")]
		public Vector2 ScaleDebris;

		// Token: 0x0400759B RID: 30107
		[Token(Token = "0x400759B")]
		[FieldOffset(Offset = "0x68")]
		public Vector2 ScaleVirtualGoods;

		// Token: 0x0400759C RID: 30108
		[Token(Token = "0x400759C")]
		[FieldOffset(Offset = "0x70")]
		public Vector2 ScaleAvatar;

		// Token: 0x0400759D RID: 30109
		[Token(Token = "0x400759D")]
		[FieldOffset(Offset = "0x78")]
		public Vector2 ScaleBundle;

		// Token: 0x0400759E RID: 30110
		[Token(Token = "0x400759E")]
		[FieldOffset(Offset = "0x80")]
		public Vector2 ScaleOptionalBundle;

		// Token: 0x0400759F RID: 30111
		[Token(Token = "0x400759F")]
		[FieldOffset(Offset = "0x88")]
		public Vector2 ScaleCloth;

		// Token: 0x040075A0 RID: 30112
		[Token(Token = "0x40075A0")]
		[FieldOffset(Offset = "0x90")]
		public Vector2 ScaleBonusCard;

		// Token: 0x040075A1 RID: 30113
		[Token(Token = "0x40075A1")]
		[FieldOffset(Offset = "0x98")]
		public Vector2 ScaleBackpack;

		// Token: 0x040075A2 RID: 30114
		[Token(Token = "0x40075A2")]
		[FieldOffset(Offset = "0xA0")]
		public Vector2 ScaleBanner;

		// Token: 0x040075A3 RID: 30115
		[Token(Token = "0x40075A3")]
		[FieldOffset(Offset = "0xA8")]
		public Vector2 ScaleHeadPic;

		// Token: 0x040075A4 RID: 30116
		[Token(Token = "0x40075A4")]
		[FieldOffset(Offset = "0xB0")]
		public Vector2 ScaleLootBox;

		// Token: 0x040075A5 RID: 30117
		[Token(Token = "0x40075A5")]
		[FieldOffset(Offset = "0xB8")]
		public Vector2 ScaleParachute;

		// Token: 0x040075A6 RID: 30118
		[Token(Token = "0x40075A6")]
		[FieldOffset(Offset = "0xC0")]
		public Vector2 ScaleSkyboard;

		// Token: 0x040075A7 RID: 30119
		[Token(Token = "0x40075A7")]
		[FieldOffset(Offset = "0xC8")]
		public Vector2 ScaleFlight;

		// Token: 0x040075A8 RID: 30120
		[Token(Token = "0x40075A8")]
		[FieldOffset(Offset = "0xD0")]
		public Vector2 ScaleWeapon;

		// Token: 0x040075A9 RID: 30121
		[Token(Token = "0x40075A9")]
		[FieldOffset(Offset = "0xD8")]
		public Vector2 ScaleGrenade;

		// Token: 0x040075AA RID: 30122
		[Token(Token = "0x40075AA")]
		[FieldOffset(Offset = "0xE0")]
		public Vector2 ScaleVehicle;

		// Token: 0x040075AB RID: 30123
		[Token(Token = "0x40075AB")]
		[FieldOffset(Offset = "0xE8")]
		public Vector2 ScaleEmote;

		// Token: 0x040075AC RID: 30124
		[Token(Token = "0x40075AC")]
		[FieldOffset(Offset = "0xF0")]
		public float RotateWeapon;

		// Token: 0x040075AD RID: 30125
		[Token(Token = "0x40075AD")]
		[FieldOffset(Offset = "0xF4")]
		public bool UseDefaultColor;

		// Token: 0x040075AE RID: 30126
		[Token(Token = "0x40075AE")]
		[FieldOffset(Offset = "0xF8")]
		public Vector2 CurrentUseScale;

		// Token: 0x040075AF RID: 30127
		[Token(Token = "0x40075AF")]
		[FieldOffset(Offset = "0x100")]
		private UILabel m_ValueLabel;

		// Token: 0x040075B0 RID: 30128
		[Token(Token = "0x40075B0")]
		[FieldOffset(Offset = "0x108")]
		private BoxCollider m_BoxCollider;

		// Token: 0x040075B1 RID: 30129
		[Token(Token = "0x40075B1")]
		[FieldOffset(Offset = "0x110")]
		private UIEventListener m_Listener;

		// Token: 0x040075B2 RID: 30130
		[Token(Token = "0x40075B2")]
		[FieldOffset(Offset = "0x118")]
		public int m_OriHeight;

		// Token: 0x040075B3 RID: 30131
		[Token(Token = "0x40075B3")]
		[FieldOffset(Offset = "0x11C")]
		public int m_OriWidth;

		// Token: 0x040075B4 RID: 30132
		[Token(Token = "0x40075B4")]
		[FieldOffset(Offset = "0x120")]
		public int m_Ori_BgWidth;

		// Token: 0x040075B5 RID: 30133
		[Token(Token = "0x40075B5")]
		[FieldOffset(Offset = "0x128")]
		private Dictionary<ActivityAwardItem.ScaleKey, Vector2> m_ScaleMap;

		// Token: 0x040075B6 RID: 30134
		[Token(Token = "0x40075B6")]
		[FieldOffset(Offset = "0x130")]
		private int m_BGPaddingX;

		// Token: 0x040075B7 RID: 30135
		[Token(Token = "0x40075B7")]
		[FieldOffset(Offset = "0x138")]
		private BaseItemInfo m_Data;

		// Token: 0x040075B8 RID: 30136
		[Token(Token = "0x40075B8")]
		[FieldOffset(Offset = "0x140")]
		private CSSharedItemData m_ItemData;

		// Token: 0x040075B9 RID: 30137
		[Token(Token = "0x40075B9")]
		[FieldOffset(Offset = "0x148")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F72C", Offset = "0x112F72C")]
		private int <TargetBGWidth>k__BackingField;

		// Token: 0x0200134F RID: 4943
		[Token(Token = "0x200134F")]
		private class ScaleKey
		{
			// Token: 0x06004E97 RID: 20119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E97")]
			[Address(RVA = "0x1F9A734", Offset = "0x1F9A734", VA = "0x7BBC79A734")]
			public ScaleKey(CSSharedItemDataManager.ItemType itemType, uint subType)
			{
			}

			// Token: 0x040075BA RID: 30138
			[Token(Token = "0x40075BA")]
			[FieldOffset(Offset = "0x10")]
			public CSSharedItemDataManager.ItemType itemType;

			// Token: 0x040075BB RID: 30139
			[Token(Token = "0x40075BB")]
			[FieldOffset(Offset = "0x14")]
			public uint subType;
		}

		// Token: 0x02001350 RID: 4944
		[Token(Token = "0x2001350")]
		private class ScaleKeyCompare : IEqualityComparer<ActivityAwardItem.ScaleKey>
		{
			// Token: 0x06004E98 RID: 20120 RVA: 0x00018048 File Offset: 0x00016248
			[Token(Token = "0x6004E98")]
			[Address(RVA = "0x1F9C364", Offset = "0x1F9C364", VA = "0x7BBC79C364", Slot = "4")]
			private bool Equals(ActivityAwardItem.ScaleKey x, ActivityAwardItem.ScaleKey y)
			{
				return default(bool);
			}

			// Token: 0x06004E99 RID: 20121 RVA: 0x00018060 File Offset: 0x00016260
			[Token(Token = "0x6004E99")]
			[Address(RVA = "0x1F9C3CC", Offset = "0x1F9C3CC", VA = "0x7BBC79C3CC", Slot = "5")]
			private int GetHashCode(ActivityAwardItem.ScaleKey obj)
			{
				return 0;
			}

			// Token: 0x06004E9A RID: 20122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E9A")]
			[Address(RVA = "0x1F9A72C", Offset = "0x1F9A72C", VA = "0x7BBC79A72C")]
			public ScaleKeyCompare()
			{
			}
		}
	}
}
