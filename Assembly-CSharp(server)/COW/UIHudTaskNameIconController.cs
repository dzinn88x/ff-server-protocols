using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C01 RID: 7169
	[Token(Token = "0x2001C01")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FB544", Offset = "0x10FB544")]
	internal class UIHudTaskNameIconController : UIHudNameBaseController
	{
		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06009BCF RID: 39887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5B")]
		public LevelTaskZone BindedLevelObject
		{
			[Token(Token = "0x6009BCF")]
			[Address(RVA = "0x167C978", Offset = "0x167C978", VA = "0x7BBBE7C978")]
			get
			{
				return null;
			}
		}

		// Token: 0x06009BD0 RID: 39888 RVA: 0x00028EA8 File Offset: 0x000270A8
		[Token(Token = "0x6009BD0")]
		[Address(RVA = "0x167C980", Offset = "0x167C980", VA = "0x7BBBE7C980")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06009BD1 RID: 39889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD1")]
		[Address(RVA = "0x167C9D0", Offset = "0x167C9D0", VA = "0x7BBBE7C9D0", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06009BD2 RID: 39890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD2")]
		[Address(RVA = "0x167CAB8", Offset = "0x167CAB8", VA = "0x7BBBE7CAB8", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06009BD3 RID: 39891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD3")]
		[Address(RVA = "0x167CB84", Offset = "0x167CB84", VA = "0x7BBBE7CB84")]
		public void BindLevelObject(LevelTaskZone obj)
		{
		}

		// Token: 0x06009BD4 RID: 39892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD4")]
		[Address(RVA = "0x167CB8C", Offset = "0x167CB8C", VA = "0x7BBBE7CB8C")]
		public void ClearBind()
		{
		}

		// Token: 0x06009BD5 RID: 39893 RVA: 0x00028EC0 File Offset: 0x000270C0
		[Token(Token = "0x6009BD5")]
		[Address(RVA = "0x167CD1C", Offset = "0x167CD1C", VA = "0x7BBBE7CD1C", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06009BD6 RID: 39894 RVA: 0x00028ED8 File Offset: 0x000270D8
		[Token(Token = "0x6009BD6")]
		[Address(RVA = "0x167CE04", Offset = "0x167CE04", VA = "0x7BBBE7CE04", Slot = "29")]
		protected override bool NeedAutoScaleByDistance()
		{
			return default(bool);
		}

		// Token: 0x06009BD7 RID: 39895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD7")]
		[Address(RVA = "0x167CE0C", Offset = "0x167CE0C", VA = "0x7BBBE7CE0C")]
		public void SetEmergency(bool isEmergency)
		{
		}

		// Token: 0x06009BD8 RID: 39896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD8")]
		[Address(RVA = "0x167CE18", Offset = "0x167CE18", VA = "0x7BBBE7CE18")]
		private void RefreshIconVisibility()
		{
		}

		// Token: 0x06009BD9 RID: 39897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BD9")]
		[Address(RVA = "0x167CE98", Offset = "0x167CE98", VA = "0x7BBBE7CE98")]
		private void OnRefreshIcon(params object[] data)
		{
		}

		// Token: 0x06009BDA RID: 39898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BDA")]
		[Address(RVA = "0x167CF28", Offset = "0x167CF28", VA = "0x7BBBE7CF28", Slot = "36")]
		protected override void UpdateNamePosition()
		{
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06009BDB RID: 39899 RVA: 0x00028EF0 File Offset: 0x000270F0
		[Token(Token = "0x17000A5C")]
		private bool IsInTutorial
		{
			[Token(Token = "0x6009BDB")]
			[Address(RVA = "0x167CC38", Offset = "0x167CC38", VA = "0x7BBBE7CC38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06009BDC RID: 39900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BDC")]
		[Address(RVA = "0x167D038", Offset = "0x167D038", VA = "0x7BBBE7D038")]
		public void ShowTutorial(bool isWolf)
		{
		}

		// Token: 0x06009BDD RID: 39901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009BDD")]
		[Address(RVA = "0x167D140", Offset = "0x167D140", VA = "0x7BBBE7D140")]
		public UIHudTaskNameIconController()
		{
		}

		// Token: 0x0400A1F5 RID: 41461
		[Token(Token = "0x400A1F5")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudTaskNameIconView m_View;

		// Token: 0x0400A1F6 RID: 41462
		[Token(Token = "0x400A1F6")]
		[FieldOffset(Offset = "0xB0")]
		private LevelTaskZone bindedLevelObject;

		// Token: 0x0400A1F7 RID: 41463
		[Token(Token = "0x400A1F7")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_onlyEmergency;

		// Token: 0x0400A1F8 RID: 41464
		[Token(Token = "0x400A1F8")]
		[FieldOffset(Offset = "0xB9")]
		private bool m_isEmergency;

		// Token: 0x0400A1F9 RID: 41465
		[Token(Token = "0x400A1F9")]
		[FieldOffset(Offset = "0xBC")]
		private TutorialEventEnum m_CurTutType;
	}
}
