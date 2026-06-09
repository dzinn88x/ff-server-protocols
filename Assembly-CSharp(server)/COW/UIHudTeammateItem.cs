using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C70 RID: 7280
	[Token(Token = "0x2001C70")]
	internal class UIHudTeammateItem : MonoBehaviour
	{
		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06009EBD RID: 40637 RVA: 0x00029760 File Offset: 0x00027960
		[Token(Token = "0x17000A75")]
		public ETeammateState CurrentState
		{
			[Token(Token = "0x6009EBD")]
			[Address(RVA = "0x15DB914", Offset = "0x15DB914", VA = "0x7BBBDDB914")]
			get
			{
				return ETeammateState.eNone;
			}
		}

		// Token: 0x06009EBE RID: 40638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EBE")]
		[Address(RVA = "0x15DB91C", Offset = "0x15DB91C", VA = "0x7BBBDDB91C")]
		private void Awake()
		{
		}

		// Token: 0x06009EBF RID: 40639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EBF")]
		[Address(RVA = "0x15DBABC", Offset = "0x15DBABC", VA = "0x7BBBDDBABC")]
		private void OnDestroy()
		{
		}

		// Token: 0x06009EC0 RID: 40640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC0")]
		[Address(RVA = "0x15DBC0C", Offset = "0x15DBC0C", VA = "0x7BBBDDBC0C")]
		public void Show(bool v)
		{
		}

		// Token: 0x06009EC1 RID: 40641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC1")]
		[Address(RVA = "0x15DBC48", Offset = "0x15DBC48", VA = "0x7BBBDDBC48")]
		private void OnGridReposition()
		{
		}

		// Token: 0x06009EC2 RID: 40642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC2")]
		[Address(RVA = "0x15DBCE4", Offset = "0x15DBCE4", VA = "0x7BBBDDBCE4")]
		private void UpdateCelebrity(uint role)
		{
		}

		// Token: 0x06009EC3 RID: 40643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC3")]
		[Address(RVA = "0x15DBE58", Offset = "0x15DBE58", VA = "0x7BBBDDBE58", Slot = "4")]
		public virtual void InitInfo(Player p)
		{
		}

		// Token: 0x06009EC4 RID: 40644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC4")]
		[Address(RVA = "0x15DCEEC", Offset = "0x15DCEEC", VA = "0x7BBBDDCEEC", Slot = "5")]
		public virtual void InitInfo(cfSip\u007Fz.^|dlTwk p)
		{
		}

		// Token: 0x06009EC5 RID: 40645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC5")]
		[Address(RVA = "0x15DD32C", Offset = "0x15DD32C", VA = "0x7BBBDDD32C")]
		public void OnKnockDownStateChanged(bool isDown, float ratio)
		{
		}

		// Token: 0x06009EC6 RID: 40646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC6")]
		[Address(RVA = "0x15DD3F4", Offset = "0x15DD3F4", VA = "0x7BBBDDD3F4", Slot = "6")]
		public virtual void InitWithPlayerInfo(^|dlTwk playerInfo)
		{
		}

		// Token: 0x06009EC7 RID: 40647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC7")]
		[Address(RVA = "0x15DC578", Offset = "0x15DC578", VA = "0x7BBBDDC578")]
		public void SetVoiceVisible(bool flag)
		{
		}

		// Token: 0x06009EC8 RID: 40648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC8")]
		[Address(RVA = "0x15DC500", Offset = "0x15DC500", VA = "0x7BBBDDC500")]
		public void SetMuteVisible(bool is_mute)
		{
		}

		// Token: 0x06009EC9 RID: 40649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009EC9")]
		[Address(RVA = "0x15DC83C", Offset = "0x15DC83C", VA = "0x7BBBDDC83C")]
		public void SetMarkShow(bool show)
		{
		}

		// Token: 0x06009ECA RID: 40650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ECA")]
		[Address(RVA = "0x15DC5F0", Offset = "0x15DC5F0", VA = "0x7BBBDDC5F0")]
		public void SetTeammateState(ETeammateState nextState)
		{
		}

		// Token: 0x06009ECB RID: 40651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ECB")]
		[Address(RVA = "0x15DC420", Offset = "0x15DC420", VA = "0x7BBBDDC420")]
		public void SetDisconnected(bool disconnected)
		{
		}

		// Token: 0x06009ECC RID: 40652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ECC")]
		[Address(RVA = "0x15DD994", Offset = "0x15DD994", VA = "0x7BBBDDD994", Slot = "7")]
		public virtual void OnHPChanged(Player p)
		{
		}

		// Token: 0x06009ECD RID: 40653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ECD")]
		[Address(RVA = "0x15DC88C", Offset = "0x15DC88C", VA = "0x7BBBDDC88C")]
		private void InitModeRelatedInfo(Player p)
		{
		}

		// Token: 0x06009ECE RID: 40654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ECE")]
		[Address(RVA = "0x15DD6B4", Offset = "0x15DD6B4", VA = "0x7BBBDDD6B4")]
		private void InitModeRelatedInfo(^|dlTwk p)
		{
		}

		// Token: 0x06009ECF RID: 40655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ECF")]
		[Address(RVA = "0x15DD254", Offset = "0x15DD254", VA = "0x7BBBDDD254")]
		private void InitModeRelatedInfo(cfSip\u007Fz.^|dlTwk p)
		{
		}

		// Token: 0x06009ED0 RID: 40656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ED0")]
		[Address(RVA = "0x15DDDA4", Offset = "0x15DDDA4", VA = "0x7BBBDDDDA4")]
		public void UpdateModeRelatedInfo(byte num)
		{
		}

		// Token: 0x06009ED1 RID: 40657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ED1")]
		[Address(RVA = "0x15DDBD0", Offset = "0x15DDBD0", VA = "0x7BBBDDDBD0")]
		public void UpdateTrainingZoneIcon(byte val)
		{
		}

		// Token: 0x06009ED2 RID: 40658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ED2")]
		[Address(RVA = "0x15DD7B0", Offset = "0x15DD7B0", VA = "0x7BBBDDD7B0")]
		public void UpdateBombModeBomb()
		{
		}

		// Token: 0x06009ED3 RID: 40659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ED3")]
		[Address(RVA = "0x15DDED0", Offset = "0x15DDED0", VA = "0x7BBBDDDED0")]
		public void UpdateADSMode1v1Info(params object[] data)
		{
		}

		// Token: 0x06009ED4 RID: 40660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ED4")]
		[Address(RVA = "0x15DE250", Offset = "0x15DE250", VA = "0x7BBBDDE250")]
		public void ShowADS1v1Winner(bool show)
		{
		}

		// Token: 0x06009ED5 RID: 40661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ED5")]
		[Address(RVA = "0x15DE410", Offset = "0x15DE410", VA = "0x7BBBDDE410")]
		public void ShowModeRelatedEffect(bool show)
		{
		}

		// Token: 0x06009ED6 RID: 40662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ED6")]
		[Address(RVA = "0x15DE448", Offset = "0x15DE448", VA = "0x7BBBDDE448")]
		public void Update()
		{
		}

		// Token: 0x06009ED7 RID: 40663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009ED7")]
		[Address(RVA = "0x15DE578", Offset = "0x15DE578", VA = "0x7BBBDDE578")]
		public UIHudTeammateItem()
		{
		}

		// Token: 0x0400A525 RID: 42277
		[Token(Token = "0x400A525")]
		[FieldOffset(Offset = "0x18")]
		public UILabel Name;

		// Token: 0x0400A526 RID: 42278
		[Token(Token = "0x400A526")]
		[FieldOffset(Offset = "0x20")]
		public GameObject HPBarGO;

		// Token: 0x0400A527 RID: 42279
		[Token(Token = "0x400A527")]
		[FieldOffset(Offset = "0x28")]
		public UISprite HP;

		// Token: 0x0400A528 RID: 42280
		[Token(Token = "0x400A528")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Mark;

		// Token: 0x0400A529 RID: 42281
		[Token(Token = "0x400A529")]
		[FieldOffset(Offset = "0x38")]
		public GameObject KillerGO;

		// Token: 0x0400A52A RID: 42282
		[Token(Token = "0x400A52A")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TeamIndex;

		// Token: 0x0400A52B RID: 42283
		[Token(Token = "0x400A52B")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Knockdown;

		// Token: 0x0400A52C RID: 42284
		[Token(Token = "0x400A52C")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Offline;

		// Token: 0x0400A52D RID: 42285
		[Token(Token = "0x400A52D")]
		[FieldOffset(Offset = "0x58")]
		public UISprite DisFlag;

		// Token: 0x0400A52E RID: 42286
		[Token(Token = "0x400A52E")]
		[FieldOffset(Offset = "0x60")]
		public UISprite Vehicle;

		// Token: 0x0400A52F RID: 42287
		[Token(Token = "0x400A52F")]
		[FieldOffset(Offset = "0x68")]
		public GameObject VoiceGO;

		// Token: 0x0400A530 RID: 42288
		[Token(Token = "0x400A530")]
		[FieldOffset(Offset = "0x70")]
		public GameObject MutedGO;

		// Token: 0x0400A531 RID: 42289
		[Token(Token = "0x400A531")]
		[FieldOffset(Offset = "0x78")]
		public UISprite TeamParachuteIcon;

		// Token: 0x0400A532 RID: 42290
		[Token(Token = "0x400A532")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ModeRelatedContainer;

		// Token: 0x0400A533 RID: 42291
		[Token(Token = "0x400A533")]
		[FieldOffset(Offset = "0x88")]
		public UISprite ModeIcon;

		// Token: 0x0400A534 RID: 42292
		[Token(Token = "0x400A534")]
		[FieldOffset(Offset = "0x90")]
		public UILabel ModeTxt;

		// Token: 0x0400A535 RID: 42293
		[Token(Token = "0x400A535")]
		[FieldOffset(Offset = "0x98")]
		public GameObject ModeVFXEffect;

		// Token: 0x0400A536 RID: 42294
		[Token(Token = "0x400A536")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject Effect_Glow;

		// Token: 0x0400A537 RID: 42295
		[Token(Token = "0x400A537")]
		[FieldOffset(Offset = "0xA8")]
		public UIGrid m_CelebrityGrid;

		// Token: 0x0400A538 RID: 42296
		[Token(Token = "0x400A538")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite TrainingZoneIcon;

		// Token: 0x0400A539 RID: 42297
		[Token(Token = "0x400A539")]
		[FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		public int TeamIndexNum;

		// Token: 0x0400A53A RID: 42298
		[Token(Token = "0x400A53A")]
		[FieldOffset(Offset = "0xC0")]
		public {QAb\u0082~u pID;

		// Token: 0x0400A53B RID: 42299
		[Token(Token = "0x400A53B")]
		[FieldOffset(Offset = "0xD8")]
		private ETeammateState m_CurrentState;

		// Token: 0x0400A53C RID: 42300
		[Token(Token = "0x400A53C")]
		[FieldOffset(Offset = "0xE0")]
		private UITimeLabelHelper m_CountDownLabel;

		// Token: 0x0400A53D RID: 42301
		[Token(Token = "0x400A53D")]
		[FieldOffset(Offset = "0xE8")]
		private BitArrayBoolean ModeRelatedContainerShow;

		// Token: 0x0400A53E RID: 42302
		[Token(Token = "0x400A53E")]
		private const uint ADS1v1CountDown = 1U;

		// Token: 0x0400A53F RID: 42303
		[Token(Token = "0x400A53F")]
		private const uint ADS1v1BonusCountDown = 2U;
	}
}
