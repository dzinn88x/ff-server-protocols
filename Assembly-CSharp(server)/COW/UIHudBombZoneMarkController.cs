using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001884 RID: 6276
	[Token(Token = "0x2001884")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F43D4", Offset = "0x10F43D4")]
	internal class UIHudBombZoneMarkController : UIHudNameBaseController
	{
		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06007C24 RID: 31780 RVA: 0x00022188 File Offset: 0x00020388
		// (set) Token: 0x06007C25 RID: 31781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000989")]
		public bool StartProgressing
		{
			[Token(Token = "0x6007C24")]
			[Address(RVA = "0x189C9B8", Offset = "0x189C9B8", VA = "0x7BBC09C9B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007C25")]
			[Address(RVA = "0x189C9C0", Offset = "0x189C9C0", VA = "0x7BBC09C9C0")]
			set
			{
			}
		}

		// Token: 0x06007C26 RID: 31782 RVA: 0x000221A0 File Offset: 0x000203A0
		[Token(Token = "0x6007C26")]
		[Address(RVA = "0x189C9CC", Offset = "0x189C9CC", VA = "0x7BBC09C9CC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007C27 RID: 31783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C27")]
		[Address(RVA = "0x189CA1C", Offset = "0x189CA1C", VA = "0x7BBC09CA1C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C28")]
		[Address(RVA = "0x189CE44", Offset = "0x189CE44", VA = "0x7BBC09CE44", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06007C29 RID: 31785 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06007C2A RID: 31786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700098A")]
		public SafeZone.f|fyNx~ BombZoneInfo
		{
			[Token(Token = "0x6007C29")]
			[Address(RVA = "0x189D060", Offset = "0x189D060", VA = "0x7BBC09D060")]
			get
			{
				return null;
			}
			[Token(Token = "0x6007C2A")]
			[Address(RVA = "0x189D068", Offset = "0x189D068", VA = "0x7BBC09D068")]
			set
			{
			}
		}

		// Token: 0x06007C2B RID: 31787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C2B")]
		[Address(RVA = "0x189D114", Offset = "0x189D114", VA = "0x7BBC09D114", Slot = "35")]
		protected override void LateUpdate()
		{
		}

		// Token: 0x06007C2C RID: 31788 RVA: 0x000221B8 File Offset: 0x000203B8
		[Token(Token = "0x6007C2C")]
		[Address(RVA = "0x189D33C", Offset = "0x189D33C", VA = "0x7BBC09D33C", Slot = "32")]
		protected override bool NeedShowDistance()
		{
			return default(bool);
		}

		// Token: 0x06007C2D RID: 31789 RVA: 0x000221D0 File Offset: 0x000203D0
		[Token(Token = "0x6007C2D")]
		[Address(RVA = "0x189D344", Offset = "0x189D344", VA = "0x7BBC09D344", Slot = "28")]
		protected override Vector3 TargetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x000221E8 File Offset: 0x000203E8
		[Token(Token = "0x6007C2E")]
		[Address(RVA = "0x189D434", Offset = "0x189D434", VA = "0x7BBC09D434", Slot = "30")]
		protected override bool NeedKeepInScreen()
		{
			return default(bool);
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x00022200 File Offset: 0x00020400
		[Token(Token = "0x6007C2F")]
		[Address(RVA = "0x189D43C", Offset = "0x189D43C", VA = "0x7BBC09D43C", Slot = "37")]
		protected override Vector2 GetWidgetBound()
		{
			return default(Vector2);
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C30")]
		[Address(RVA = "0x189D574", Offset = "0x189D574", VA = "0x7BBC09D574")]
		private void OnBombRoundChange(params object[] data)
		{
		}

		// Token: 0x06007C31 RID: 31793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C31")]
		[Address(RVA = "0x189D768", Offset = "0x189D768", VA = "0x7BBC09D768")]
		private void OnEnterBombArea(params object[] data)
		{
		}

		// Token: 0x06007C32 RID: 31794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C32")]
		[Address(RVA = "0x189D854", Offset = "0x189D854", VA = "0x7BBC09D854")]
		private void On3PPreparation(params object[] data)
		{
		}

		// Token: 0x06007C33 RID: 31795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C33")]
		[Address(RVA = "0x189DC48", Offset = "0x189DC48", VA = "0x7BBC09DC48")]
		private void OnBombSettled(params object[] data)
		{
		}

		// Token: 0x06007C34 RID: 31796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C34")]
		[Address(RVA = "0x189DE64", Offset = "0x189DE64", VA = "0x7BBC09DE64")]
		private void OnBombRemoved(params object[] data)
		{
		}

		// Token: 0x06007C35 RID: 31797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C35")]
		[Address(RVA = "0x189D628", Offset = "0x189D628", VA = "0x7BBC09D628")]
		private void SetBombArrowStatus(bool hasBomb)
		{
		}

		// Token: 0x06007C36 RID: 31798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C36")]
		[Address(RVA = "0x189E030", Offset = "0x189E030", VA = "0x7BBC09E030")]
		public UIHudBombZoneMarkController()
		{
		}

		// Token: 0x04009048 RID: 36936
		[Token(Token = "0x4009048")]
		[FieldOffset(Offset = "0xA8")]
		private UIHudBombZoneMarkView m_View;

		// Token: 0x04009049 RID: 36937
		[Token(Token = "0x4009049")]
		[FieldOffset(Offset = "0xB0")]
		private SafeZone.f|fyNx~ m_BombZoneInfo;

		// Token: 0x0400904A RID: 36938
		[Token(Token = "0x400904A")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_StartProgressing;

		// Token: 0x0400904B RID: 36939
		[Token(Token = "0x400904B")]
		[FieldOffset(Offset = "0xBC")]
		private float m_StartTime;

		// Token: 0x0400904C RID: 36940
		[Token(Token = "0x400904C")]
		[FieldOffset(Offset = "0xC0")]
		private float m_TotalTime;

		// Token: 0x0400904D RID: 36941
		[Token(Token = "0x400904D")]
		[FieldOffset(Offset = "0xC8")]
		private UISprite m_ProgressSprite;

		// Token: 0x0400904E RID: 36942
		[Token(Token = "0x400904E")]
		[FieldOffset(Offset = "0xD0")]
		private Color bombColor;
	}
}
