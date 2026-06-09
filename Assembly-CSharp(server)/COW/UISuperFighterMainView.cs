using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200256B RID: 9579
	[Token(Token = "0x200256B")]
	public class UISuperFighterMainView : UIBaseView
	{
		// Token: 0x0600C5E6 RID: 50662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E6")]
		[Address(RVA = "0x1F4BE00", Offset = "0x1F4BE00", VA = "0x7BBC74BE00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C5E7 RID: 50663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C5E7")]
		[Address(RVA = "0x1F4CF1C", Offset = "0x1F4CF1C", VA = "0x7BBC74CF1C")]
		public UISuperFighterMainView()
		{
		}

		// Token: 0x0400F5BA RID: 62906
		[Token(Token = "0x400F5BA")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400F5BB RID: 62907
		[Token(Token = "0x400F5BB")]
		[FieldOffset(Offset = "0x28")]
		public GameObject Content;

		// Token: 0x0400F5BC RID: 62908
		[Token(Token = "0x400F5BC")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture Title;

		// Token: 0x0400F5BD RID: 62909
		[Token(Token = "0x400F5BD")]
		[FieldOffset(Offset = "0x38")]
		public UIButton BtnRule;

		// Token: 0x0400F5BE RID: 62910
		[Token(Token = "0x400F5BE")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TimeLabel;

		// Token: 0x0400F5BF RID: 62911
		[Token(Token = "0x400F5BF")]
		[FieldOffset(Offset = "0x48")]
		public UIButton BtnToken1;

		// Token: 0x0400F5C0 RID: 62912
		[Token(Token = "0x400F5C0")]
		[FieldOffset(Offset = "0x50")]
		public UISprite TokenIcon1;

		// Token: 0x0400F5C1 RID: 62913
		[Token(Token = "0x400F5C1")]
		[FieldOffset(Offset = "0x58")]
		public UILabel TokenNum1;

		// Token: 0x0400F5C2 RID: 62914
		[Token(Token = "0x400F5C2")]
		[FieldOffset(Offset = "0x60")]
		public Transform TipsContainer1;

		// Token: 0x0400F5C3 RID: 62915
		[Token(Token = "0x400F5C3")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnToken2;

		// Token: 0x0400F5C4 RID: 62916
		[Token(Token = "0x400F5C4")]
		[FieldOffset(Offset = "0x70")]
		public UISprite TokenIcon2;

		// Token: 0x0400F5C5 RID: 62917
		[Token(Token = "0x400F5C5")]
		[FieldOffset(Offset = "0x78")]
		public UILabel TokenNum2;

		// Token: 0x0400F5C6 RID: 62918
		[Token(Token = "0x400F5C6")]
		[FieldOffset(Offset = "0x80")]
		public Transform TipsContainer2;

		// Token: 0x0400F5C7 RID: 62919
		[Token(Token = "0x400F5C7")]
		[FieldOffset(Offset = "0x88")]
		public UIButton BtnPeakDay;

		// Token: 0x0400F5C8 RID: 62920
		[Token(Token = "0x400F5C8")]
		[FieldOffset(Offset = "0x90")]
		public UILabel PeakDayBubble;

		// Token: 0x0400F5C9 RID: 62921
		[Token(Token = "0x400F5C9")]
		[FieldOffset(Offset = "0x98")]
		public TweenScale PeakDayBubbleShake;

		// Token: 0x0400F5CA RID: 62922
		[Token(Token = "0x400F5CA")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton BtnMission;

		// Token: 0x0400F5CB RID: 62923
		[Token(Token = "0x400F5CB")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton BtnAwardPreview;

		// Token: 0x0400F5CC RID: 62924
		[Token(Token = "0x400F5CC")]
		[FieldOffset(Offset = "0xB0")]
		public TweenScale RewardPreviewBubble;

		// Token: 0x0400F5CD RID: 62925
		[Token(Token = "0x400F5CD")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel RewardPreviewBubbleDesc;

		// Token: 0x0400F5CE RID: 62926
		[Token(Token = "0x400F5CE")]
		[FieldOffset(Offset = "0xC0")]
		public UINetworkTexture BigRewardPreview;

		// Token: 0x0400F5CF RID: 62927
		[Token(Token = "0x400F5CF")]
		[FieldOffset(Offset = "0xC8")]
		public UIButton BtnWeb;

		// Token: 0x0400F5D0 RID: 62928
		[Token(Token = "0x400F5D0")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject Center;

		// Token: 0x0400F5D1 RID: 62929
		[Token(Token = "0x400F5D1")]
		[FieldOffset(Offset = "0xD8")]
		public UISlider PlayerHPSlider;

		// Token: 0x0400F5D2 RID: 62930
		[Token(Token = "0x400F5D2")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel PlayerHPPercent;

		// Token: 0x0400F5D3 RID: 62931
		[Token(Token = "0x400F5D3")]
		[FieldOffset(Offset = "0xE8")]
		public UISlider EnemyHPSlider;

		// Token: 0x0400F5D4 RID: 62932
		[Token(Token = "0x400F5D4")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel EnemyHPPercent;

		// Token: 0x0400F5D5 RID: 62933
		[Token(Token = "0x400F5D5")]
		[FieldOffset(Offset = "0xF8")]
		public UIGrid EnemyStageGrid;

		// Token: 0x0400F5D6 RID: 62934
		[Token(Token = "0x400F5D6")]
		[FieldOffset(Offset = "0x100")]
		public UISprite EnemySign;

		// Token: 0x0400F5D7 RID: 62935
		[Token(Token = "0x400F5D7")]
		[FieldOffset(Offset = "0x108")]
		public UILabel EnemyStage;

		// Token: 0x0400F5D8 RID: 62936
		[Token(Token = "0x400F5D8")]
		[FieldOffset(Offset = "0x110")]
		public Animation Fight;

		// Token: 0x0400F5D9 RID: 62937
		[Token(Token = "0x400F5D9")]
		[FieldOffset(Offset = "0x118")]
		public TweenPosition Player;

		// Token: 0x0400F5DA RID: 62938
		[Token(Token = "0x400F5DA")]
		[FieldOffset(Offset = "0x120")]
		public GameObject PlayerSpine1;

		// Token: 0x0400F5DB RID: 62939
		[Token(Token = "0x400F5DB")]
		[FieldOffset(Offset = "0x128")]
		public GameObject PlayerSpine2;

		// Token: 0x0400F5DC RID: 62940
		[Token(Token = "0x400F5DC")]
		[FieldOffset(Offset = "0x130")]
		public GameObject PlayerSpine3;

		// Token: 0x0400F5DD RID: 62941
		[Token(Token = "0x400F5DD")]
		[FieldOffset(Offset = "0x138")]
		public GameObject VFX_PlayerEnter;

		// Token: 0x0400F5DE RID: 62942
		[Token(Token = "0x400F5DE")]
		[FieldOffset(Offset = "0x140")]
		public UILabel PlayerTakeDamageValue;

		// Token: 0x0400F5DF RID: 62943
		[Token(Token = "0x400F5DF")]
		[FieldOffset(Offset = "0x148")]
		public GameObject CloseUpPlayer;

		// Token: 0x0400F5E0 RID: 62944
		[Token(Token = "0x400F5E0")]
		[FieldOffset(Offset = "0x150")]
		public UITexture CloseUpPlayerTexture;

		// Token: 0x0400F5E1 RID: 62945
		[Token(Token = "0x400F5E1")]
		[FieldOffset(Offset = "0x158")]
		public GameObject VFX_PlayerSkill3Only;

		// Token: 0x0400F5E2 RID: 62946
		[Token(Token = "0x400F5E2")]
		[FieldOffset(Offset = "0x160")]
		public Transform PlayerAttackVFX;

		// Token: 0x0400F5E3 RID: 62947
		[Token(Token = "0x400F5E3")]
		[FieldOffset(Offset = "0x168")]
		public Transform PlayerHurtVFX;

		// Token: 0x0400F5E4 RID: 62948
		[Token(Token = "0x400F5E4")]
		[FieldOffset(Offset = "0x170")]
		public TweenPosition Enemy;

		// Token: 0x0400F5E5 RID: 62949
		[Token(Token = "0x400F5E5")]
		[FieldOffset(Offset = "0x178")]
		public GameObject EnemySpine1;

		// Token: 0x0400F5E6 RID: 62950
		[Token(Token = "0x400F5E6")]
		[FieldOffset(Offset = "0x180")]
		public GameObject EnemySpine2;

		// Token: 0x0400F5E7 RID: 62951
		[Token(Token = "0x400F5E7")]
		[FieldOffset(Offset = "0x188")]
		public GameObject EnemySpine3;

		// Token: 0x0400F5E8 RID: 62952
		[Token(Token = "0x400F5E8")]
		[FieldOffset(Offset = "0x190")]
		public GameObject VFX_EnemyEnter;

		// Token: 0x0400F5E9 RID: 62953
		[Token(Token = "0x400F5E9")]
		[FieldOffset(Offset = "0x198")]
		public UILabel EnemyTakeDamageValue;

		// Token: 0x0400F5EA RID: 62954
		[Token(Token = "0x400F5EA")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject CloseUpEnemy;

		// Token: 0x0400F5EB RID: 62955
		[Token(Token = "0x400F5EB")]
		[FieldOffset(Offset = "0x1A8")]
		public UITexture CloseUpEnemyTexture;

		// Token: 0x0400F5EC RID: 62956
		[Token(Token = "0x400F5EC")]
		[FieldOffset(Offset = "0x1B0")]
		public GameObject VFX_EnemySkill3Only;

		// Token: 0x0400F5ED RID: 62957
		[Token(Token = "0x400F5ED")]
		[FieldOffset(Offset = "0x1B8")]
		public Transform EnemyAttackVFX;

		// Token: 0x0400F5EE RID: 62958
		[Token(Token = "0x400F5EE")]
		[FieldOffset(Offset = "0x1C0")]
		public Transform EnemyHurtVFX;

		// Token: 0x0400F5EF RID: 62959
		[Token(Token = "0x400F5EF")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject Box;

		// Token: 0x0400F5F0 RID: 62960
		[Token(Token = "0x400F5F0")]
		[FieldOffset(Offset = "0x1D0")]
		public UISprite BoxIcon;

		// Token: 0x0400F5F1 RID: 62961
		[Token(Token = "0x400F5F1")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject VFX_BoxDropBigReward;

		// Token: 0x0400F5F2 RID: 62962
		[Token(Token = "0x400F5F2")]
		[FieldOffset(Offset = "0x1E0")]
		public GameObject VFX_BoxDropNormal;

		// Token: 0x0400F5F3 RID: 62963
		[Token(Token = "0x400F5F3")]
		[FieldOffset(Offset = "0x1E8")]
		public GameObject VFX_BoxDropDefeat;

		// Token: 0x0400F5F4 RID: 62964
		[Token(Token = "0x400F5F4")]
		[FieldOffset(Offset = "0x1F0")]
		public Transform DefeatAwardDropAnchor;

		// Token: 0x0400F5F5 RID: 62965
		[Token(Token = "0x400F5F5")]
		[FieldOffset(Offset = "0x1F8")]
		public Transform VictoryAwardDropAnchor;

		// Token: 0x0400F5F6 RID: 62966
		[Token(Token = "0x400F5F6")]
		[FieldOffset(Offset = "0x200")]
		public UIButton BtnSkill1;

		// Token: 0x0400F5F7 RID: 62967
		[Token(Token = "0x400F5F7")]
		[FieldOffset(Offset = "0x208")]
		public UILabel Skill1DamageRange;

		// Token: 0x0400F5F8 RID: 62968
		[Token(Token = "0x400F5F8")]
		[FieldOffset(Offset = "0x210")]
		public UISprite Skill1TokenIcon;

		// Token: 0x0400F5F9 RID: 62969
		[Token(Token = "0x400F5F9")]
		[FieldOffset(Offset = "0x218")]
		public UILabel Skill1TokenNum;

		// Token: 0x0400F5FA RID: 62970
		[Token(Token = "0x400F5FA")]
		[FieldOffset(Offset = "0x220")]
		public UIButton BtnSkill2;

		// Token: 0x0400F5FB RID: 62971
		[Token(Token = "0x400F5FB")]
		[FieldOffset(Offset = "0x228")]
		public UILabel Skill2DamageRange;

		// Token: 0x0400F5FC RID: 62972
		[Token(Token = "0x400F5FC")]
		[FieldOffset(Offset = "0x230")]
		public UISprite Skill2TokenIcon;

		// Token: 0x0400F5FD RID: 62973
		[Token(Token = "0x400F5FD")]
		[FieldOffset(Offset = "0x238")]
		public UILabel Skill2TokenNum;

		// Token: 0x0400F5FE RID: 62974
		[Token(Token = "0x400F5FE")]
		[FieldOffset(Offset = "0x240")]
		public UIButton BtnSkill3;

		// Token: 0x0400F5FF RID: 62975
		[Token(Token = "0x400F5FF")]
		[FieldOffset(Offset = "0x248")]
		public UILabel Skill3DamageRange;

		// Token: 0x0400F600 RID: 62976
		[Token(Token = "0x400F600")]
		[FieldOffset(Offset = "0x250")]
		public UISprite Skill3TokenIcon;

		// Token: 0x0400F601 RID: 62977
		[Token(Token = "0x400F601")]
		[FieldOffset(Offset = "0x258")]
		public UILabel Skill3TokenNum;

		// Token: 0x0400F602 RID: 62978
		[Token(Token = "0x400F602")]
		[FieldOffset(Offset = "0x260")]
		public GameObject Mask;
	}
}
