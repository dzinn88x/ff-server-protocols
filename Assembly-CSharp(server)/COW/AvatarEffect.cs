using System;
using System.Collections.Generic;
using Beebyte.Obfuscator;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;
using UnityEngine.Rendering;

namespace COW
{
	// Token: 0x02001089 RID: 4233
	[Token(Token = "0x2001089")]
	public class AvatarEffect : MonoBehaviour
	{
		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060040FF RID: 16639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000772")]
		public IUmaAvatar Avatar
		{
			[Token(Token = "0x60040FF")]
			[Address(RVA = "0x155E2D8", Offset = "0x155E2D8", VA = "0x7BBBD5E2D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06004100 RID: 16640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004101 RID: 16641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000773")]
		public Entity OwnerPlayer
		{
			[Token(Token = "0x6004100")]
			[Address(RVA = "0x155E390", Offset = "0x155E390", VA = "0x7BBBD5E390")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C568", Offset = "0x113C568")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004101")]
			[Address(RVA = "0x155E398", Offset = "0x155E398", VA = "0x7BBBD5E398")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C578", Offset = "0x113C578")]
			set
			{
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06004102 RID: 16642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000774")]
		public Transform CachedTransform
		{
			[Token(Token = "0x6004102")]
			[Address(RVA = "0x155E3A0", Offset = "0x155E3A0", VA = "0x7BBBD5E3A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004103")]
		[Address(RVA = "0x155E430", Offset = "0x155E430", VA = "0x7BBBD5E430")]
		private void Start()
		{
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004104")]
		[Address(RVA = "0x155E488", Offset = "0x155E488", VA = "0x7BBBD5E488")]
		[SkipRename]
		public void PlayFistAttack(int right)
		{
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004105")]
		[Address(RVA = "0x155E58C", Offset = "0x155E58C", VA = "0x7BBBD5E58C")]
		public void PlayLobbyAnimEffect(ResourceID id)
		{
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004106")]
		[Address(RVA = "0x155EDFC", Offset = "0x155EDFC", VA = "0x7BBBD5EDFC")]
		[SkipRename]
		public void PlayEmoteAnimEffect(string ResourceIDName)
		{
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004107")]
		[Address(RVA = "0x155F9E0", Offset = "0x155F9E0", VA = "0x7BBBD5F9E0")]
		[SkipRename]
		public void PlayAnimEffectByName(string ResourceIDName)
		{
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004108")]
		[Address(RVA = "0x155FB80", Offset = "0x155FB80", VA = "0x7BBBD5FB80")]
		[SkipRename]
		public void PlayAnimEffect(AnimationEvent evt)
		{
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004109")]
		[Address(RVA = "0x155FD60", Offset = "0x155FD60", VA = "0x7BBBD5FD60")]
		public void PlayAnimEffectWithPrefab(GameObject prefab)
		{
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410A")]
		[Address(RVA = "0x155FD6C", Offset = "0x155FD6C", VA = "0x7BBBD5FD6C")]
		[SkipRename]
		public void PlayIdleAnimEffect(GameObject prefab)
		{
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410B")]
		[Address(RVA = "0x155F088", Offset = "0x155F088", VA = "0x7BBBD5F088")]
		public void PlayAnimEffect(GameObject prefab, AvatarEffect.EEffectGroup group, int emoteID = 0)
		{
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410C")]
		[Address(RVA = "0x155E6AC", Offset = "0x155E6AC", VA = "0x7BBBD5E6AC")]
		public void PlayLobbyAnimEffect(GameObject prefab, AvatarEffect.EEffectGroup group, int emoteID = 0)
		{
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410D")]
		[Address(RVA = "0x1560A04", Offset = "0x1560A04", VA = "0x7BBBD60A04")]
		private void ProcessBoneNameRefsWithNoSave(GameObject go, AvatarEffect.EEffectGroup group)
		{
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410E")]
		[Address(RVA = "0x15602B4", Offset = "0x15602B4", VA = "0x7BBBD602B4")]
		private void ProcessBoneNameRefs(GameObject go, AvatarEffect.EEffectGroup group)
		{
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410F")]
		[Address(RVA = "0x15600A0", Offset = "0x15600A0", VA = "0x7BBBD600A0")]
		private void ProcessCastShadow(GameObject go, ShadowCastingMode shadowCastingMode)
		{
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x00013F80 File Offset: 0x00012180
		[Token(Token = "0x6004110")]
		[Address(RVA = "0x15610EC", Offset = "0x15610EC", VA = "0x7BBBD610EC")]
		public bool ScaleInLocalSpace(GameObject o)
		{
			return default(bool);
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x00013F98 File Offset: 0x00012198
		[Token(Token = "0x6004111")]
		[Address(RVA = "0x15611F8", Offset = "0x15611F8", VA = "0x7BBBD611F8")]
		public bool HasEmoteEffect(AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
		{
			return default(bool);
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004112")]
		[Address(RVA = "0x155FEDC", Offset = "0x155FEDC", VA = "0x7BBBD5FEDC")]
		public void ClearEffects(AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
		{
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004113")]
		[Address(RVA = "0x15612AC", Offset = "0x15612AC", VA = "0x7BBBD612AC")]
		public void ClearLobbyAnimeEffect()
		{
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004114")]
		[Address(RVA = "0x1561444", Offset = "0x1561444", VA = "0x7BBBD61444")]
		public List<GameObject> GetEffectsByType(AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
		{
			return null;
		}

		// Token: 0x06004115 RID: 16661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004115")]
		[Address(RVA = "0x15614CC", Offset = "0x15614CC", VA = "0x7BBBD614CC")]
		public void EnableSpecialEffect(bool bEnable)
		{
		}

		// Token: 0x06004116 RID: 16662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004116")]
		[Address(RVA = "0x15614D8", Offset = "0x15614D8", VA = "0x7BBBD614D8")]
		private void StartSpecialEffect()
		{
		}

		// Token: 0x06004117 RID: 16663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004117")]
		[Address(RVA = "0x1561800", Offset = "0x1561800", VA = "0x7BBBD61800")]
		private void StopSpecialEffect()
		{
		}

		// Token: 0x06004118 RID: 16664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004118")]
		[Address(RVA = "0x1561B1C", Offset = "0x1561B1C", VA = "0x7BBBD61B1C")]
		private void FindSpecialEffect()
		{
		}

		// Token: 0x06004119 RID: 16665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004119")]
		[Address(RVA = "0x1561EDC", Offset = "0x1561EDC", VA = "0x7BBBD61EDC")]
		public AvatarEffect()
		{
		}

		// Token: 0x04005071 RID: 20593
		[Token(Token = "0x4005071")]
		[FieldOffset(Offset = "0x18")]
		private Renderer m_renderer;

		// Token: 0x04005072 RID: 20594
		[Token(Token = "0x4005072")]
		[FieldOffset(Offset = "0x20")]
		private List<int> m_avatarMatIDList;

		// Token: 0x04005073 RID: 20595
		[Token(Token = "0x4005073")]
		[FieldOffset(Offset = "0x28")]
		private bool m_foundSpecialEffect;

		// Token: 0x04005074 RID: 20596
		[Token(Token = "0x4005074")]
		[FieldOffset(Offset = "0x30")]
		private Player m_owner;

		// Token: 0x04005075 RID: 20597
		[Token(Token = "0x4005075")]
		[FieldOffset(Offset = "0x38")]
		private UIMaleAvatar m_LobbyAvatar;

		// Token: 0x04005076 RID: 20598
		[Token(Token = "0x4005076")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<AvatarEffect.EEffectGroup, List<GameObject>> m_AnimEffects;

		// Token: 0x04005077 RID: 20599
		[Token(Token = "0x4005077")]
		[FieldOffset(Offset = "0x48")]
		private List<GameObject> m_LobbyAnimList;

		// Token: 0x04005078 RID: 20600
		[Token(Token = "0x4005078")]
		[FieldOffset(Offset = "0x50")]
		private IUmaAvatar m_Avatar;

		// Token: 0x04005079 RID: 20601
		[Token(Token = "0x4005079")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EBEC", Offset = "0x112EBEC")]
		private Entity <OwnerPlayer>k__BackingField;

		// Token: 0x0400507A RID: 20602
		[Token(Token = "0x400507A")]
		[FieldOffset(Offset = "0x60")]
		private Transform m_CachedTransform;

		// Token: 0x0200108A RID: 4234
		[Token(Token = "0x200108A")]
		public enum EEffectGroup
		{
			// Token: 0x0400507C RID: 20604
			[Token(Token = "0x400507C")]
			Default,
			// Token: 0x0400507D RID: 20605
			[Token(Token = "0x400507D")]
			External
		}
	}
}
