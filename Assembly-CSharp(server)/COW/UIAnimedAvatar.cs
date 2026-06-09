using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Beebyte.Obfuscator;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW
{
	// Token: 0x02001449 RID: 5193
	[Token(Token = "0x2001449")]
	public class UIAnimedAvatar : UIAvatar
	{
		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x0600567F RID: 22143 RVA: 0x00019AB8 File Offset: 0x00017CB8
		[Token(Token = "0x1700088C")]
		public bool RealPlaySpecialIdle
		{
			[Token(Token = "0x600567F")]
			[Address(RVA = "0x1969D18", Offset = "0x1969D18", VA = "0x7BBC169D18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06005680 RID: 22144 RVA: 0x00019AD0 File Offset: 0x00017CD0
		// (set) Token: 0x06005681 RID: 22145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700088D")]
		public bool UsingClothProp
		{
			[Token(Token = "0x6005680")]
			[Address(RVA = "0x1969D20", Offset = "0x1969D20", VA = "0x7BBC169D20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113EDFC", Offset = "0x113EDFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005681")]
			[Address(RVA = "0x1969D28", Offset = "0x1969D28", VA = "0x7BBC169D28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113EE0C", Offset = "0x113EE0C")]
			set
			{
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06005682 RID: 22146 RVA: 0x00019AE8 File Offset: 0x00017CE8
		// (set) Token: 0x06005683 RID: 22147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700088E")]
		public bool UsingAvatarProp
		{
			[Token(Token = "0x6005682")]
			[Address(RVA = "0x1969D34", Offset = "0x1969D34", VA = "0x7BBC169D34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005683")]
			[Address(RVA = "0x1969D3C", Offset = "0x1969D3C", VA = "0x7BBC169D3C")]
			set
			{
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06005684 RID: 22148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088F")]
		public Animator PlayerAnimator
		{
			[Token(Token = "0x6005684")]
			[Address(RVA = "0x1969D48", Offset = "0x1969D48", VA = "0x7BBC169D48")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005685")]
		[Address(RVA = "0x1969D50", Offset = "0x1969D50", VA = "0x7BBC169D50", Slot = "20")]
		public override void InitAvatar(bool isLocal, bool isPreview = false, int textureScale = 1)
		{
		}

		// Token: 0x06005686 RID: 22150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005686")]
		[Address(RVA = "0x1969E10", Offset = "0x1969E10", VA = "0x7BBC169E10", Slot = "24")]
		protected override void CharacterUpdateCallBack(UMAData umaData)
		{
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005687")]
		[Address(RVA = "0x1969FEC", Offset = "0x1969FEC", VA = "0x7BBC169FEC")]
		private void SetUpDynamicEffect()
		{
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005688")]
		[Address(RVA = "0x196A09C", Offset = "0x196A09C", VA = "0x7BBC16A09C")]
		private void ResetAnims()
		{
		}

		// Token: 0x06005689 RID: 22153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005689")]
		[Address(RVA = "0x196A3F8", Offset = "0x196A3F8", VA = "0x7BBC16A3F8", Slot = "33")]
		protected override void OnSetAvatarDone(CSSharedAvatarData aData)
		{
		}

		// Token: 0x0600568A RID: 22154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600568A")]
		[Address(RVA = "0x196A8DC", Offset = "0x196A8DC", VA = "0x7BBC16A8DC", Slot = "29")]
		protected override void ChangeRace(string race)
		{
		}

		// Token: 0x0600568B RID: 22155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600568B")]
		[Address(RVA = "0x196A514", Offset = "0x196A514", VA = "0x7BBC16A514")]
		public void UpdatePropItem()
		{
		}

		// Token: 0x0600568C RID: 22156 RVA: 0x00019B00 File Offset: 0x00017D00
		[Token(Token = "0x600568C")]
		[Address(RVA = "0x196A918", Offset = "0x196A918", VA = "0x7BBC16A918")]
		public bool CheckAvatarHasWeapon()
		{
			return default(bool);
		}

		// Token: 0x0600568D RID: 22157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600568D")]
		[Address(RVA = "0x196A92C", Offset = "0x196A92C", VA = "0x7BBC16A92C")]
		protected void Update()
		{
		}

		// Token: 0x0600568E RID: 22158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600568E")]
		[Address(RVA = "0x196AAD4", Offset = "0x196AAD4", VA = "0x7BBC16AAD4", Slot = "35")]
		protected virtual void DoUpdate()
		{
		}

		// Token: 0x0600568F RID: 22159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600568F")]
		[Address(RVA = "0x196ADCC", Offset = "0x196ADCC", VA = "0x7BBC16ADCC", Slot = "34")]
		public override void ResetAvatar()
		{
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005690")]
		[Address(RVA = "0x196B14C", Offset = "0x196B14C", VA = "0x7BBC16B14C")]
		public void ResetWeaponShow()
		{
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x00019B18 File Offset: 0x00017D18
		[Token(Token = "0x6005691")]
		[Address(RVA = "0x196B1F8", Offset = "0x196B1F8", VA = "0x7BBC16B1F8")]
		public bool CheckLobbyEmoteAnim()
		{
			return default(bool);
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005692")]
		[Address(RVA = "0x196B200", Offset = "0x196B200", VA = "0x7BBC16B200")]
		public void SetAvatar(UIMaleAvatar avatar)
		{
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005693")]
		[Address(RVA = "0x196B2D4", Offset = "0x196B2D4", VA = "0x7BBC16B2D4")]
		public void PlayAnimClipAtLobby(ResourceID resId, bool needdelayshow = false)
		{
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005694")]
		[Address(RVA = "0x196B7C8", Offset = "0x196B7C8", VA = "0x7BBC16B7C8")]
		public void RegisterCoAtLobbyCallback(Action callback)
		{
		}

		// Token: 0x06005695 RID: 22165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005695")]
		[Address(RVA = "0x196B860", Offset = "0x196B860", VA = "0x7BBC16B860")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113EE1C", Offset = "0x113EE1C")]
		private IEnumerator CoPlayAnimClipAtLobby(ResourceID resId, bool loop = false)
		{
			return null;
		}

		// Token: 0x06005696 RID: 22166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005696")]
		[Address(RVA = "0x196B914", Offset = "0x196B914", VA = "0x7BBC16B914")]
		public void PlayEmotionAnimation(uint emotionID, bool loop = false)
		{
		}

		// Token: 0x06005697 RID: 22167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005697")]
		[Address(RVA = "0x196B7D0", Offset = "0x196B7D0", VA = "0x7BBC16B7D0")]
		protected void CleanLastAnimLegacy()
		{
		}

		// Token: 0x06005698 RID: 22168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005698")]
		[Address(RVA = "0x196BA9C", Offset = "0x196BA9C", VA = "0x7BBC16BA9C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113EE80", Offset = "0x113EE80")]
		private IEnumerator CoPlayEmotionAnimationd(uint emotionID, bool loop = false)
		{
			return null;
		}

		// Token: 0x06005699 RID: 22169 RVA: 0x00019B30 File Offset: 0x00017D30
		[Token(Token = "0x6005699")]
		[Address(RVA = "0x196BB50", Offset = "0x196BB50", VA = "0x7BBC16BB50")]
		public bool GetIsPlayEmotion()
		{
			return default(bool);
		}

		// Token: 0x0600569A RID: 22170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569A")]
		[Address(RVA = "0x196BA64", Offset = "0x196BA64", VA = "0x7BBC16BA64")]
		public void StopPlayEmotionAnim()
		{
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600569B")]
		[Address(RVA = "0x196A360", Offset = "0x196A360", VA = "0x7BBC16A360")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113EEE4", Offset = "0x113EEE4")]
		private IEnumerator PlayGunCoroutine(UIAnimedAvatar.GunType type)
		{
			return null;
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569C")]
		[Address(RVA = "0x196BB58", Offset = "0x196BB58", VA = "0x7BBC16BB58")]
		public void StopEmotionAnimation()
		{
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569D")]
		[Address(RVA = "0x196BB9C", Offset = "0x196BB9C", VA = "0x7BBC16BB9C")]
		private void EnsureMotionManager()
		{
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569E")]
		[Address(RVA = "0x196BC14", Offset = "0x196BC14", VA = "0x7BBC16BC14")]
		protected void SetTrigger(string s)
		{
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569F")]
		[Address(RVA = "0x196BCC4", Offset = "0x196BCC4", VA = "0x7BBC16BCC4")]
		protected void ResetTrigger(string s)
		{
		}

		// Token: 0x060056A0 RID: 22176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A0")]
		[Address(RVA = "0x196ABAC", Offset = "0x196ABAC", VA = "0x7BBC16ABAC")]
		private void UpdateShowPoseAnim()
		{
		}

		// Token: 0x060056A1 RID: 22177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A1")]
		[Address(RVA = "0x196BE30", Offset = "0x196BE30", VA = "0x7BBC16BE30")]
		public void SetSpecialIdeEnabled(bool flag)
		{
		}

		// Token: 0x060056A2 RID: 22178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A2")]
		[Address(RVA = "0x196AC14", Offset = "0x196AC14", VA = "0x7BBC16AC14")]
		private void UpdateSpecialIdleAnim()
		{
		}

		// Token: 0x060056A3 RID: 22179 RVA: 0x00019B48 File Offset: 0x00017D48
		[Token(Token = "0x60056A3")]
		[Address(RVA = "0x196C118", Offset = "0x196C118", VA = "0x7BBC16C118")]
		public bool GetIsRecylceProp()
		{
			return default(bool);
		}

		// Token: 0x060056A4 RID: 22180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A4")]
		[Address(RVA = "0x196C10C", Offset = "0x196C10C", VA = "0x7BBC16C10C")]
		public void SetRecycleProp(bool flag)
		{
		}

		// Token: 0x060056A5 RID: 22181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A5")]
		[Address(RVA = "0x196BDA4", Offset = "0x196BDA4", VA = "0x7BBC16BDA4")]
		private void PlayShowPoseAnim()
		{
		}

		// Token: 0x060056A6 RID: 22182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A6")]
		[Address(RVA = "0x196A2BC", Offset = "0x196A2BC", VA = "0x7BBC16A2BC")]
		private void StopShowPoseAnim(bool cleareffect = true)
		{
		}

		// Token: 0x060056A7 RID: 22183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A7")]
		[Address(RVA = "0x196C120", Offset = "0x196C120", VA = "0x7BBC16C120", Slot = "36")]
		public virtual void StartShowPose()
		{
		}

		// Token: 0x060056A8 RID: 22184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056A8")]
		[Address(RVA = "0x196C470", Offset = "0x196C470", VA = "0x7BBC16C470")]
		public void UpdateWeaponOnHand(uint skinID)
		{
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x00019B60 File Offset: 0x00017D60
		[Token(Token = "0x60056A9")]
		[Address(RVA = "0x196C63C", Offset = "0x196C63C", VA = "0x7BBC16C63C")]
		private bool IsDualWeild(WeaponSkinData data)
		{
			return default(bool);
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056AA")]
		[Address(RVA = "0x196C798", Offset = "0x196C798", VA = "0x7BBC16C798", Slot = "37")]
		public virtual void StopShowPose(bool cleareffect = true)
		{
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056AB")]
		[Address(RVA = "0x196C464", Offset = "0x196C464", VA = "0x7BBC16C464")]
		protected void SetShowPosing(bool b)
		{
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060056AC RID: 22188 RVA: 0x00019B78 File Offset: 0x00017D78
		[Token(Token = "0x17000890")]
		private bool IsIdleAnimReplaced
		{
			[Token(Token = "0x60056AC")]
			[Address(RVA = "0x196BD74", Offset = "0x196BD74", VA = "0x7BBC16BD74")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060056AD RID: 22189 RVA: 0x00019B90 File Offset: 0x00017D90
		// (set) Token: 0x060056AE RID: 22190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000891")]
		public bool IsWeaponIdleAnimReplaced
		{
			[Token(Token = "0x60056AD")]
			[Address(RVA = "0x196C7A4", Offset = "0x196C7A4", VA = "0x7BBC16C7A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113EF48", Offset = "0x113EF48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60056AE")]
			[Address(RVA = "0x196C7AC", Offset = "0x196C7AC", VA = "0x7BBC16C7AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113EF58", Offset = "0x113EF58")]
			set
			{
			}
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x00019BA8 File Offset: 0x00017DA8
		[Token(Token = "0x60056AF")]
		[Address(RVA = "0x196C7B8", Offset = "0x196C7B8", VA = "0x7BBC16C7B8")]
		public bool IsShowSpecialIdle()
		{
			return default(bool);
		}

		// Token: 0x060056B0 RID: 22192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B0")]
		[Address(RVA = "0x196A104", Offset = "0x196A104", VA = "0x7BBC16A104")]
		private void UpdateClothesChangeAnim()
		{
		}

		// Token: 0x060056B1 RID: 22193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B1")]
		[Address(RVA = "0x196A290", Offset = "0x196A290", VA = "0x7BBC16A290")]
		private void TryPlayPreviewAvatarAnimation()
		{
		}

		// Token: 0x060056B2 RID: 22194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B2")]
		[Address(RVA = "0x196D108", Offset = "0x196D108", VA = "0x7BBC16D108")]
		private void PlayPreviewPose()
		{
		}

		// Token: 0x060056B3 RID: 22195 RVA: 0x00019BC0 File Offset: 0x00017DC0
		[Token(Token = "0x60056B3")]
		[Address(RVA = "0x196C438", Offset = "0x196C438", VA = "0x7BBC16C438")]
		private bool IsSpecialPreviewOnlyAvatar()
		{
			return default(bool);
		}

		// Token: 0x060056B4 RID: 22196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B4")]
		[Address(RVA = "0x196C95C", Offset = "0x196C95C", VA = "0x7BBC16C95C")]
		private void OverrideClothesAnim(ReplaceAnimData data, bool changeClothes)
		{
		}

		// Token: 0x060056B5 RID: 22197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B5")]
		[Address(RVA = "0x196D724", Offset = "0x196D724", VA = "0x7BBC16D724")]
		private void OverrideClothesAnim(ResourceID id, bool changeAnim)
		{
		}

		// Token: 0x060056B6 RID: 22198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B6")]
		[Address(RVA = "0x196D1F8", Offset = "0x196D1F8", VA = "0x7BBC16D1F8")]
		private void OverrideClothesAnim(AnimationClip clip, bool changeAnim)
		{
		}

		// Token: 0x060056B7 RID: 22199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B7")]
		[Address(RVA = "0x196DE90", Offset = "0x196DE90", VA = "0x7BBC16DE90")]
		protected void ResetOverrideWeaponIdleAnim()
		{
		}

		// Token: 0x060056B8 RID: 22200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056B8")]
		[Address(RVA = "0x196D258", Offset = "0x196D258", VA = "0x7BBC16D258")]
		private AnimationClip GetClothesAnimClip(bool baseClip, bool changeAnim)
		{
			return null;
		}

		// Token: 0x060056B9 RID: 22201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056B9")]
		[Address(RVA = "0x196D02C", Offset = "0x196D02C", VA = "0x7BBC16D02C")]
		private void PlayClothesChangeAnim()
		{
		}

		// Token: 0x060056BA RID: 22202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BA")]
		[Address(RVA = "0x196E0D0", Offset = "0x196E0D0", VA = "0x7BBC16E0D0")]
		private void StopClothesChangeAnim(bool cleareffect = true)
		{
		}

		// Token: 0x060056BB RID: 22203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BB")]
		[Address(RVA = "0x196E170", Offset = "0x196E170", VA = "0x7BBC16E170")]
		public void PlayCustomAnim(ResourceID rid)
		{
		}

		// Token: 0x060056BC RID: 22204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BC")]
		[Address(RVA = "0x196E358", Offset = "0x196E358", VA = "0x7BBC16E358")]
		public void ReplaceAnimByName(ResourceID rid, string name)
		{
		}

		// Token: 0x060056BD RID: 22205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BD")]
		[Address(RVA = "0x196E550", Offset = "0x196E550", VA = "0x7BBC16E550")]
		public void SetSkipCustomParm(bool flag)
		{
		}

		// Token: 0x060056BE RID: 22206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056BE")]
		[Address(RVA = "0x196E55C", Offset = "0x196E55C", VA = "0x7BBC16E55C")]
		public void StopAvatarAnim(bool cleareffect)
		{
		}

		// Token: 0x060056BF RID: 22207 RVA: 0x00019BD8 File Offset: 0x00017DD8
		[Token(Token = "0x60056BF")]
		[Address(RVA = "0x196E75C", Offset = "0x196E75C", VA = "0x7BBC16E75C")]
		public ResourceID GetClothesChangeAnim(AvatarWardrobeData aData)
		{
			return default(ResourceID);
		}

		// Token: 0x060056C0 RID: 22208 RVA: 0x00019BF0 File Offset: 0x00017DF0
		[Token(Token = "0x60056C0")]
		[Address(RVA = "0x196E7D4", Offset = "0x196E7D4", VA = "0x7BBC16E7D4")]
		public ResourceID GetClothesIdleAnim(AvatarWardrobeData aData)
		{
			return default(ResourceID);
		}

		// Token: 0x060056C1 RID: 22209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C1")]
		[Address(RVA = "0x196E84C", Offset = "0x196E84C", VA = "0x7BBC16E84C")]
		public void PlayClothesAnims(uint wId, bool playChangeAnim, bool playIdleAnim, bool waitDirty = true)
		{
		}

		// Token: 0x060056C2 RID: 22210 RVA: 0x00019C08 File Offset: 0x00017E08
		[Token(Token = "0x60056C2")]
		[Address(RVA = "0x196E98C", Offset = "0x196E98C", VA = "0x7BBC16E98C")]
		internal bool PlayClothesAnims(AvatarWardrobeData aData, bool playChangeAnim, bool playIdleAnim)
		{
			return default(bool);
		}

		// Token: 0x060056C3 RID: 22211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C3")]
		[Address(RVA = "0x196EBAC", Offset = "0x196EBAC", VA = "0x7BBC16EBAC")]
		public void PlayFacialAnim(uint wId)
		{
		}

		// Token: 0x060056C4 RID: 22212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C4")]
		[Address(RVA = "0x196EBEC", Offset = "0x196EBEC", VA = "0x7BBC16EBEC")]
		public void PlayFacialAnim(AvatarWardrobeData wData)
		{
		}

		// Token: 0x060056C5 RID: 22213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C5")]
		[Address(RVA = "0x196EBF8", Offset = "0x196EBF8", VA = "0x7BBC16EBF8")]
		public void PlayFacialAnim(UIModelAvatarBase.EWardrobeType wType = UIModelAvatarBase.EWardrobeType.CLOTHESTYPENONE)
		{
		}

		// Token: 0x060056C6 RID: 22214 RVA: 0x00019C20 File Offset: 0x00017E20
		[Token(Token = "0x60056C6")]
		[Address(RVA = "0x196EB10", Offset = "0x196EB10", VA = "0x7BBC16EB10")]
		protected bool PlayClothesChangeAnim(ResourceID resId, ResourceID effectID)
		{
			return default(bool);
		}

		// Token: 0x060056C7 RID: 22215 RVA: 0x00019C38 File Offset: 0x00017E38
		[Token(Token = "0x60056C7")]
		[Address(RVA = "0x196EB28", Offset = "0x196EB28", VA = "0x7BBC16EB28")]
		protected bool PlayClothesIdleAnim(ResourceID resId)
		{
			return default(bool);
		}

		// Token: 0x060056C8 RID: 22216 RVA: 0x00019C50 File Offset: 0x00017E50
		[Token(Token = "0x60056C8")]
		[Address(RVA = "0x196E620", Offset = "0x196E620", VA = "0x7BBC16E620")]
		protected bool CheckAndOverrideAnim(ReplaceAnimData data, ResourceID id, ResourceID effectID)
		{
			return default(bool);
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056C9")]
		[Address(RVA = "0x196AF4C", Offset = "0x196AF4C", VA = "0x7BBC16AF4C")]
		internal void StopClothesChangeAnims()
		{
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056CA")]
		[Address(RVA = "0x196A70C", Offset = "0x196A70C", VA = "0x7BBC16A70C")]
		protected void ResetClothesDefaultAnims()
		{
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056CB")]
		[Address(RVA = "0x196EDB0", Offset = "0x196EDB0", VA = "0x7BBC16EDB0")]
		protected void ResetClothesOverrideAnims()
		{
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056CC")]
		[Address(RVA = "0x196AB08", Offset = "0x196AB08", VA = "0x7BBC16AB08")]
		private void UpdateGunAnimation()
		{
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056CD")]
		[Address(RVA = "0x196EE00", Offset = "0x196EE00", VA = "0x7BBC16EE00")]
		private void PlayGunAnimation(UIAnimedAvatar.GunType type)
		{
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056CE")]
		[Address(RVA = "0x196F018", Offset = "0x196F018", VA = "0x7BBC16F018")]
		public void ResetRunTimeAnimController()
		{
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x00019C68 File Offset: 0x00017E68
		[Token(Token = "0x60056CF")]
		[Address(RVA = "0x196EE70", Offset = "0x196EE70", VA = "0x7BBC16EE70")]
		private ResourceID GetIdleAnimResByGunType(UIAnimedAvatar.GunType type)
		{
			return default(ResourceID);
		}

		// Token: 0x060056D0 RID: 22224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D0")]
		[Address(RVA = "0x196F1B4", Offset = "0x196F1B4", VA = "0x7BBC16F1B4")]
		private void ForcePlayAnim(UIAnimedAvatar.GunType type)
		{
		}

		// Token: 0x060056D1 RID: 22225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D1")]
		[Address(RVA = "0x196EF80", Offset = "0x196EF80", VA = "0x7BBC16EF80")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113EF68", Offset = "0x113EF68")]
		private IEnumerator SetGunAnimTrigger(UIAnimedAvatar.GunType type)
		{
			return null;
		}

		// Token: 0x060056D2 RID: 22226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D2")]
		[Address(RVA = "0x196F454", Offset = "0x196F454", VA = "0x7BBC16F454")]
		private void ResetAvatarOtherAnim()
		{
		}

		// Token: 0x060056D3 RID: 22227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D3")]
		[Address(RVA = "0x196F3CC", Offset = "0x196F3CC", VA = "0x7BBC16F3CC")]
		protected string GetGunAnimTriggerName(UIAnimedAvatar.GunType type)
		{
			return null;
		}

		// Token: 0x060056D4 RID: 22228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D4")]
		[Address(RVA = "0x196F4E0", Offset = "0x196F4E0", VA = "0x7BBC16F4E0")]
		public void StartShowAvatar()
		{
		}

		// Token: 0x060056D5 RID: 22229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D5")]
		[Address(RVA = "0x196F4E4", Offset = "0x196F4E4", VA = "0x7BBC16F4E4")]
		public void SetRootFlagAndSkinEnabled(bool flag)
		{
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D6")]
		[Address(RVA = "0x196F500", Offset = "0x196F500", VA = "0x7BBC16F500")]
		public void ResetAvatarReady()
		{
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D7")]
		[Address(RVA = "0x196F508", Offset = "0x196F508", VA = "0x7BBC16F508")]
		public void PlayDoubleSpecialAnim()
		{
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D8")]
		[Address(RVA = "0x196F8F8", Offset = "0x196F8F8", VA = "0x7BBC16F8F8")]
		public void SetSkipAnimParm(bool flag)
		{
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056D9")]
		[Address(RVA = "0x196F904", Offset = "0x196F904", VA = "0x7BBC16F904")]
		public void SetCharcterRootAndSkinVisble(bool enabled)
		{
		}

		// Token: 0x060056DA RID: 22234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DA")]
		[Address(RVA = "0x196FC98", Offset = "0x196FC98", VA = "0x7BBC16FC98")]
		public void InitAvatarVisibleState()
		{
		}

		// Token: 0x060056DB RID: 22235 RVA: 0x00019C80 File Offset: 0x00017E80
		[Token(Token = "0x60056DB")]
		[Address(RVA = "0x196FCB4", Offset = "0x196FCB4", VA = "0x7BBC16FCB4")]
		public bool IsSkinnedRendererActive()
		{
			return default(bool);
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DC")]
		[Address(RVA = "0x196B3B8", Offset = "0x196B3B8", VA = "0x7BBC16B3B8")]
		public void SetCharcterRootScaleAndSkinVisble(bool bVisible, uint flag = 1U)
		{
		}

		// Token: 0x060056DD RID: 22237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DD")]
		[Address(RVA = "0x196C718", Offset = "0x196C718", VA = "0x7BBC16C718")]
		public void ShowWeapon(bool show = true)
		{
		}

		// Token: 0x060056DE RID: 22238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DE")]
		[Address(RVA = "0x196C658", Offset = "0x196C658", VA = "0x7BBC16C658")]
		public void PlayWithGun(MNQTu}e data, bool rebind = true, bool dualWeild = false)
		{
		}

		// Token: 0x060056DF RID: 22239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056DF")]
		[Address(RVA = "0x196FF20", Offset = "0x196FF20", VA = "0x7BBC16FF20")]
		public void PlayWithGun(ResourceID weaponresid, ResourceID weaponpaticleid, ResourceID weaponfireeffectid, ResourceID weaponfiresoundid, bool rebind = true, bool dualWeild = false)
		{
		}

		// Token: 0x060056E0 RID: 22240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E0")]
		[Address(RVA = "0x1970454", Offset = "0x1970454", VA = "0x7BBC170454")]
		private void InitGunShowTime()
		{
		}

		// Token: 0x060056E1 RID: 22241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E1")]
		[Address(RVA = "0x1970C94", Offset = "0x1970C94", VA = "0x7BBC170C94")]
		public void PlayFireEffect(bool right)
		{
		}

		// Token: 0x060056E2 RID: 22242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E2")]
		[Address(RVA = "0x1970D90", Offset = "0x1970D90", VA = "0x7BBC170D90")]
		public void PlayWithSkyBoard(ResourceID skyboardid)
		{
		}

		// Token: 0x060056E3 RID: 22243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E3")]
		[Address(RVA = "0x196C730", Offset = "0x196C730", VA = "0x7BBC16C730")]
		public void PlayGunAnim(UIAnimedAvatar.GunType type)
		{
		}

		// Token: 0x060056E4 RID: 22244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E4")]
		[Address(RVA = "0x1971008", Offset = "0x1971008", VA = "0x7BBC171008")]
		public void ForcePlayGunAnim(UIAnimedAvatar.GunType type)
		{
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E5")]
		[Address(RVA = "0x1970F4C", Offset = "0x1970F4C", VA = "0x7BBC170F4C")]
		private void CalculateShowTime()
		{
		}

		// Token: 0x060056E6 RID: 22246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E6")]
		[Address(RVA = "0x196A75C", Offset = "0x196A75C", VA = "0x7BBC16A75C")]
		public void SetAvatarShowPoseInterval(uint avatarid)
		{
		}

		// Token: 0x060056E7 RID: 22247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E7")]
		[Address(RVA = "0x1971058", Offset = "0x1971058", VA = "0x7BBC171058")]
		public void PlayDoubleIdleAnim()
		{
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E8")]
		[Address(RVA = "0x1971100", Offset = "0x1971100", VA = "0x7BBC171100")]
		public void PlayStandIdle()
		{
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056E9")]
		[Address(RVA = "0x19711B0", Offset = "0x19711B0", VA = "0x7BBC1711B0")]
		public void PlayOnlyIdle()
		{
		}

		// Token: 0x060056EA RID: 22250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056EA")]
		[Address(RVA = "0x1971208", Offset = "0x1971208", VA = "0x7BBC171208")]
		public void StopPlayGunCoroutine()
		{
		}

		// Token: 0x060056EB RID: 22251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056EB")]
		[Address(RVA = "0x197126C", Offset = "0x197126C", VA = "0x7BBC17126C")]
		public void ResetAnimAvatar()
		{
		}

		// Token: 0x060056EC RID: 22252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056EC")]
		[Address(RVA = "0x196AF74", Offset = "0x196AF74", VA = "0x7BBC16AF74")]
		public void StopGunAnim(bool stopCortine = false)
		{
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056ED")]
		[Address(RVA = "0x196A5A4", Offset = "0x196A5A4", VA = "0x7BBC16A5A4")]
		private void UpdateShowingWepon()
		{
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056EE")]
		[Address(RVA = "0x19713D8", Offset = "0x19713D8", VA = "0x7BBC1713D8")]
		[SkipRename]
		public void RequestSpawnBattleFlagOnHand()
		{
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056EF")]
		[Address(RVA = "0x1971500", Offset = "0x1971500", VA = "0x7BBC171500")]
		[SkipRename]
		public void RequestSpawnBattleFlagOnGround()
		{
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F0")]
		[Address(RVA = "0x1971534", Offset = "0x1971534", VA = "0x7BBC171534")]
		[SkipRename]
		public void HideBattleFlagOnHand()
		{
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F1")]
		[Address(RVA = "0x196B858", Offset = "0x196B858", VA = "0x7BBC16B858")]
		public void ClearCachedBattleFlag()
		{
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F2")]
		[Address(RVA = "0x19715AC", Offset = "0x19715AC", VA = "0x7BBC1715AC")]
		private void CacheTransforms(Transform tr, Dictionary<Transform, UIAnimedAvatar.TransCache> map, bool clearParent)
		{
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F3")]
		[Address(RVA = "0x1969EAC", Offset = "0x1969EAC", VA = "0x7BBC169EAC")]
		protected void RebindPlayerAnimator()
		{
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F4")]
		[Address(RVA = "0x196A804", Offset = "0x196A804", VA = "0x7BBC16A804")]
		private void UpdateSetLookAt()
		{
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056F5")]
		[Address(RVA = "0x19718F8", Offset = "0x19718F8", VA = "0x7BBC1718F8", Slot = "38")]
		public virtual void UpdateAnimator(CSSharedAvatarData aData, bool female)
		{
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x00019C98 File Offset: 0x00017E98
		[Token(Token = "0x60056F6")]
		[Address(RVA = "0x196C7E4", Offset = "0x196C7E4", VA = "0x7BBC16C7E4")]
		private bool CheckCanRandomAnimClip(ResourceID id)
		{
			return default(bool);
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F7")]
		[Address(RVA = "0x196CB00", Offset = "0x196CB00", VA = "0x7BBC16CB00")]
		private AnimationClip GetSpeicalIdleAnimClip(ResourceID id)
		{
			return null;
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F8")]
		[Address(RVA = "0x196CEE0", Offset = "0x196CEE0", VA = "0x7BBC16CEE0")]
		private AnimationClip GetCommonIdleAnimClip(ResourceID id)
		{
			return null;
		}

		// Token: 0x060056F9 RID: 22265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F9")]
		[Address(RVA = "0x196D8D0", Offset = "0x196D8D0", VA = "0x7BBC16D8D0")]
		private AnimationClip LoadAnimClip(ResourceID id)
		{
			return null;
		}

		// Token: 0x060056FA RID: 22266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FA")]
		[Address(RVA = "0x196DA20", Offset = "0x196DA20", VA = "0x7BBC16DA20")]
		private void OverrideAnimClip(AnimationClip clip, AnimationClip baseClip)
		{
		}

		// Token: 0x060056FB RID: 22267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FB")]
		[Address(RVA = "0x196D758", Offset = "0x196D758", VA = "0x7BBC16D758")]
		public void PlayEffect(ResourceID id, AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
		{
		}

		// Token: 0x060056FC RID: 22268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FC")]
		[Address(RVA = "0x1971C88", Offset = "0x1971C88", VA = "0x7BBC171C88")]
		public void StartRecordIdle()
		{
		}

		// Token: 0x060056FD RID: 22269 RVA: 0x00019CB0 File Offset: 0x00017EB0
		[Token(Token = "0x60056FD")]
		[Address(RVA = "0x1971C98", Offset = "0x1971C98", VA = "0x7BBC171C98")]
		public bool CanShowWeapon()
		{
			return default(bool);
		}

		// Token: 0x060056FE RID: 22270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FE")]
		[Address(RVA = "0x1971CA0", Offset = "0x1971CA0", VA = "0x7BBC171CA0")]
		public void OnAnimationVisibilityChanged(int visilbe)
		{
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60056FF")]
		[Address(RVA = "0x1971CB0", Offset = "0x1971CB0", VA = "0x7BBC171CB0")]
		public void OnAnimEvent(rp|ntBG e, params object[] para)
		{
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005700")]
		[Address(RVA = "0x1971E50", Offset = "0x1971E50", VA = "0x7BBC171E50")]
		private void OnDisableDynamicBones()
		{
		}

		// Token: 0x06005701 RID: 22273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005701")]
		[Address(RVA = "0x1971F4C", Offset = "0x1971F4C", VA = "0x7BBC171F4C")]
		private void OnEnableDynamicBones()
		{
		}

		// Token: 0x06005702 RID: 22274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005702")]
		[Address(RVA = "0x1972054", Offset = "0x1972054", VA = "0x7BBC172054")]
		public void SetAnimatorStatus(bool acitve)
		{
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005703")]
		[Address(RVA = "0x19722C0", Offset = "0x19722C0", VA = "0x7BBC1722C0")]
		[SkipRename]
		public void HideDynamicCharacter()
		{
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005704")]
		[Address(RVA = "0x19722DC", Offset = "0x19722DC", VA = "0x7BBC1722DC")]
		[SkipRename]
		public void ShowDynamicCharacter()
		{
		}

		// Token: 0x06005705 RID: 22277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005705")]
		[Address(RVA = "0x19722E8", Offset = "0x19722E8", VA = "0x7BBC1722E8")]
		[SkipRename]
		public void DisableCharacterRoate()
		{
		}

		// Token: 0x06005706 RID: 22278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005706")]
		[Address(RVA = "0x19723BC", Offset = "0x19723BC", VA = "0x7BBC1723BC")]
		public void EnableAvatarInputHandlerComp(bool flag)
		{
		}

		// Token: 0x06005707 RID: 22279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005707")]
		[Address(RVA = "0x1972490", Offset = "0x1972490", VA = "0x7BBC172490")]
		[SkipRename]
		public void EnableCharacterRoate()
		{
		}

		// Token: 0x06005708 RID: 22280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005708")]
		[Address(RVA = "0x1972544", Offset = "0x1972544", VA = "0x7BBC172544")]
		[SkipRename]
		public void KeepCharacterRotateState(int flag)
		{
		}

		// Token: 0x06005709 RID: 22281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005709")]
		[Address(RVA = "0x1972554", Offset = "0x1972554", VA = "0x7BBC172554")]
		[SkipRename]
		public void ResetAvatarRotation()
		{
		}

		// Token: 0x0600570A RID: 22282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600570A")]
		[Address(RVA = "0x1972614", Offset = "0x1972614", VA = "0x7BBC172614")]
		[SkipRename]
		public void AnimationOver()
		{
		}

		// Token: 0x0600570B RID: 22283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600570B")]
		[Address(RVA = "0x19726B0", Offset = "0x19726B0", VA = "0x7BBC1726B0")]
		[SkipRename]
		public void PlayIdleSkipEffect(GameObject prefab)
		{
		}

		// Token: 0x0600570C RID: 22284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600570C")]
		[Address(RVA = "0x1972C64", Offset = "0x1972C64", VA = "0x7BBC172C64")]
		private void DestoryPaticleEffect()
		{
		}

		// Token: 0x0600570D RID: 22285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600570D")]
		[Address(RVA = "0x19722CC", Offset = "0x19722CC", VA = "0x7BBC1722CC")]
		private void SetDynamicCharacterVisble(bool visble)
		{
		}

		// Token: 0x0600570E RID: 22286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600570E")]
		[Address(RVA = "0x1954AF8", Offset = "0x1954AF8", VA = "0x7BBC154AF8")]
		public void StopAnimEfects(AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
		{
		}

		// Token: 0x0600570F RID: 22287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600570F")]
		[Address(RVA = "0x19727BC", Offset = "0x19727BC", VA = "0x7BBC1727BC")]
		public void PlaySkipEffect(AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
		{
		}

		// Token: 0x06005710 RID: 22288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005710")]
		[Address(RVA = "0x1972998", Offset = "0x1972998", VA = "0x7BBC172998")]
		public void PlayCommonIdleAnimEffect(AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
		{
		}

		// Token: 0x06005711 RID: 22289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005711")]
		[Address(RVA = "0x196BE40", Offset = "0x196BE40", VA = "0x7BBC16BE40")]
		public void PlaySpeicalIdleAnimEffect(AvatarEffect.EEffectGroup group = AvatarEffect.EEffectGroup.Default)
		{
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005712")]
		[Address(RVA = "0x1972E7C", Offset = "0x1972E7C", VA = "0x7BBC172E7C")]
		public void SaveDoubleAnims(string doublespecial, string doubleidle)
		{
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005713")]
		[Address(RVA = "0x196F62C", Offset = "0x196F62C", VA = "0x7BBC16F62C")]
		private void SetDoubleAnims(string doublespecial, string doubleidle)
		{
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005714")]
		[Address(RVA = "0x196CC50", Offset = "0x196CC50", VA = "0x7BBC16CC50")]
		private void SetOverrideDoubleAnim(AnimationClip clip, string pattern)
		{
		}

		// Token: 0x06005715 RID: 22293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005715")]
		[Address(RVA = "0x1972E84", Offset = "0x1972E84", VA = "0x7BBC172E84")]
		private AnimationClip GetAnimClipByPattern(RuntimeAnimatorController controller, bool baseClip, string pattern)
		{
			return null;
		}

		// Token: 0x06005716 RID: 22294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005716")]
		[Address(RVA = "0x1973244", Offset = "0x1973244", VA = "0x7BBC173244")]
		public UIAnimedAvatar()
		{
		}

		// Token: 0x06005717 RID: 22295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005717")]
		[Address(RVA = "0x1973394", Offset = "0x1973394", VA = "0x7BBC173394")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F07C", Offset = "0x113F07C")]
		private void <PlayAnimClipAtLobby>b__74_0()
		{
		}

		// Token: 0x04007B1C RID: 31516
		[Token(Token = "0x4007B1C")]
		protected const string IDLE_ANIM_PATTERN = "lobby";

		// Token: 0x04007B1D RID: 31517
		[Token(Token = "0x4007B1D")]
		protected const string CHANGE_CLOTHES_ANIM_PATTERN = "customanim";

		// Token: 0x04007B1E RID: 31518
		[Token(Token = "0x4007B1E")]
		[FieldOffset(Offset = "0x90")]
		protected Animator m_PlayerAnimator;

		// Token: 0x04007B1F RID: 31519
		[Token(Token = "0x4007B1F")]
		[FieldOffset(Offset = "0x98")]
		protected AvatarPropManager m_AvatarPropManager;

		// Token: 0x04007B20 RID: 31520
		[Token(Token = "0x4007B20")]
		[FieldOffset(Offset = "0xA0")]
		protected AvatarDynamicEffectManager m_DynamicEffectManager;

		// Token: 0x04007B21 RID: 31521
		[Token(Token = "0x4007B21")]
		[FieldOffset(Offset = "0xA8")]
		private EmotionManager m_EmotionManager;

		// Token: 0x04007B22 RID: 31522
		[Token(Token = "0x4007B22")]
		[FieldOffset(Offset = "0xB0")]
		private PropertyData m_CurrentAvatarPropData;

		// Token: 0x04007B23 RID: 31523
		[Token(Token = "0x4007B23")]
		[FieldOffset(Offset = "0xB8")]
		private PropertyData m_CurrentClothPropData;

		// Token: 0x04007B24 RID: 31524
		[Token(Token = "0x4007B24")]
		[FieldOffset(Offset = "0xC0")]
		protected bool m_PlayingShowPose;

		// Token: 0x04007B25 RID: 31525
		[Token(Token = "0x4007B25")]
		[FieldOffset(Offset = "0xC4")]
		protected float m_ShowPoseTime;

		// Token: 0x04007B26 RID: 31526
		[Token(Token = "0x4007B26")]
		[FieldOffset(Offset = "0xC8")]
		protected float m_ShowPoseAnimInterval;

		// Token: 0x04007B27 RID: 31527
		[Token(Token = "0x4007B27")]
		[FieldOffset(Offset = "0xCC")]
		protected float m_ShowPoseCoolDownSeconds;

		// Token: 0x04007B28 RID: 31528
		[Token(Token = "0x4007B28")]
		[FieldOffset(Offset = "0xD0")]
		protected bool m_IsPlayEmoteAnim;

		// Token: 0x04007B29 RID: 31529
		[Token(Token = "0x4007B29")]
		[FieldOffset(Offset = "0xD1")]
		protected bool m_IsPlayLobbyEmoteAnim;

		// Token: 0x04007B2A RID: 31530
		[Token(Token = "0x4007B2A")]
		[FieldOffset(Offset = "0xD8")]
		protected BitArrayBoolean m_IsVisible;

		// Token: 0x04007B2B RID: 31531
		[Token(Token = "0x4007B2B")]
		protected const uint ISVISIBLE_COMMON = 1U;

		// Token: 0x04007B2C RID: 31532
		[Token(Token = "0x4007B2C")]
		protected const uint ISVISIBLE_ANIMATION = 2U;

		// Token: 0x04007B2D RID: 31533
		[Token(Token = "0x4007B2D")]
		[FieldOffset(Offset = "0xE0")]
		public Action AvatarCoLobbyFinishedCallback;

		// Token: 0x04007B2E RID: 31534
		[Token(Token = "0x4007B2E")]
		[FieldOffset(Offset = "0xE8")]
		protected ReplaceAnimData m_ChangeClothesAnim;

		// Token: 0x04007B2F RID: 31535
		[Token(Token = "0x4007B2F")]
		[FieldOffset(Offset = "0xF0")]
		protected ReplaceAnimData m_IdleAnim;

		// Token: 0x04007B30 RID: 31536
		[Token(Token = "0x4007B30")]
		[FieldOffset(Offset = "0xF8")]
		private Dictionary<UIAnimedAvatar.GunType, float> m_GunShowTimeDic;

		// Token: 0x04007B31 RID: 31537
		[Token(Token = "0x4007B31")]
		[FieldOffset(Offset = "0x100")]
		private UIAnimedAvatar.GunType m_UseGunType;

		// Token: 0x04007B32 RID: 31538
		[Token(Token = "0x4007B32")]
		[FieldOffset(Offset = "0x104")]
		private bool m_NeedToPlayGun;

		// Token: 0x04007B33 RID: 31539
		[Token(Token = "0x4007B33")]
		[FieldOffset(Offset = "0x108")]
		private float m_PlayGunTime;

		// Token: 0x04007B34 RID: 31540
		[Token(Token = "0x4007B34")]
		[FieldOffset(Offset = "0x10C")]
		private bool m_FirstPlayGunIdle;

		// Token: 0x04007B35 RID: 31541
		[Token(Token = "0x4007B35")]
		[FieldOffset(Offset = "0x110")]
		private float m_ShowGunIdleSeconds;

		// Token: 0x04007B36 RID: 31542
		[Token(Token = "0x4007B36")]
		[FieldOffset(Offset = "0x114")]
		private bool m_PreviewPlayGun;

		// Token: 0x04007B37 RID: 31543
		[Token(Token = "0x4007B37")]
		[FieldOffset(Offset = "0x118")]
		protected ResourceID m_GunResId;

		// Token: 0x04007B38 RID: 31544
		[Token(Token = "0x4007B38")]
		[FieldOffset(Offset = "0x11C")]
		private ResourceID m_GunParticleId;

		// Token: 0x04007B39 RID: 31545
		[Token(Token = "0x4007B39")]
		[FieldOffset(Offset = "0x120")]
		private ResourceID m_GunFireEffectId;

		// Token: 0x04007B3A RID: 31546
		[Token(Token = "0x4007B3A")]
		[FieldOffset(Offset = "0x124")]
		private ResourceID m_GunFireSoundId;

		// Token: 0x04007B3B RID: 31547
		[Token(Token = "0x4007B3B")]
		[FieldOffset(Offset = "0x128")]
		private bool m_DualWield;

		// Token: 0x04007B3C RID: 31548
		[Token(Token = "0x4007B3C")]
		[FieldOffset(Offset = "0x130")]
		protected AnimationClip m_IdleSpecialAnim;

		// Token: 0x04007B3D RID: 31549
		[Token(Token = "0x4007B3D")]
		[FieldOffset(Offset = "0x138")]
		protected float m_PlayIdleTime;

		// Token: 0x04007B3E RID: 31550
		[Token(Token = "0x4007B3E")]
		[FieldOffset(Offset = "0x13C")]
		protected bool m_CanRecordIdle;

		// Token: 0x04007B3F RID: 31551
		[Token(Token = "0x4007B3F")]
		[FieldOffset(Offset = "0x13D")]
		protected bool m_CanPlaySpecialIdle;

		// Token: 0x04007B40 RID: 31552
		[Token(Token = "0x4007B40")]
		[FieldOffset(Offset = "0x13E")]
		protected bool m_RealPlaySpecialIdle;

		// Token: 0x04007B41 RID: 31553
		[Token(Token = "0x4007B41")]
		[FieldOffset(Offset = "0x13F")]
		protected bool m_RootScaleAndSkinEnabled;

		// Token: 0x04007B42 RID: 31554
		[Token(Token = "0x4007B42")]
		[FieldOffset(Offset = "0x140")]
		private bool m_CanInputRotate;

		// Token: 0x04007B43 RID: 31555
		[Token(Token = "0x4007B43")]
		[FieldOffset(Offset = "0x141")]
		private bool m_IsDoubleAnim;

		// Token: 0x04007B44 RID: 31556
		[Token(Token = "0x4007B44")]
		[FieldOffset(Offset = "0x142")]
		private bool m_IsRecycleProp;

		// Token: 0x04007B45 RID: 31557
		[Token(Token = "0x4007B45")]
		[FieldOffset(Offset = "0x143")]
		private bool m_SkipSpecailAnim;

		// Token: 0x04007B46 RID: 31558
		[Token(Token = "0x4007B46")]
		[FieldOffset(Offset = "0x144")]
		private float m_RandomSpeicalIdleTime;

		// Token: 0x04007B47 RID: 31559
		[Token(Token = "0x4007B47")]
		[FieldOffset(Offset = "0x148")]
		protected bool m_IsSkipCustom;

		// Token: 0x04007B48 RID: 31560
		[Token(Token = "0x4007B48")]
		[FieldOffset(Offset = "0x149")]
		protected bool m_IsAvatarReady;

		// Token: 0x04007B49 RID: 31561
		[Token(Token = "0x4007B49")]
		[FieldOffset(Offset = "0x150")]
		private BattleFlagConfigData m_BattleFlagConfigData;

		// Token: 0x04007B4A RID: 31562
		[Token(Token = "0x4007B4A")]
		[FieldOffset(Offset = "0x158")]
		protected GameObject m_OneShotObj;

		// Token: 0x04007B4B RID: 31563
		[Token(Token = "0x4007B4B")]
		[FieldOffset(Offset = "0x160")]
		public GameObject LightObj;

		// Token: 0x04007B4C RID: 31564
		[Token(Token = "0x4007B4C")]
		[FieldOffset(Offset = "0x168")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F7CC", Offset = "0x112F7CC")]
		private bool <UsingClothProp>k__BackingField;

		// Token: 0x04007B4D RID: 31565
		[Token(Token = "0x4007B4D")]
		[FieldOffset(Offset = "0x169")]
		private bool m_UsingAvatarProp;

		// Token: 0x04007B4E RID: 31566
		[Token(Token = "0x4007B4E")]
		[FieldOffset(Offset = "0x170")]
		private IEnumerator playEmontionAnimCor;

		// Token: 0x04007B4F RID: 31567
		[Token(Token = "0x4007B4F")]
		[FieldOffset(Offset = "0x178")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F7DC", Offset = "0x112F7DC")]
		private bool <IsWeaponIdleAnimReplaced>k__BackingField;

		// Token: 0x04007B50 RID: 31568
		[Token(Token = "0x4007B50")]
		[FieldOffset(Offset = "0x180")]
		protected AnimationClip CachedIdleAnimClip;

		// Token: 0x04007B51 RID: 31569
		[Token(Token = "0x4007B51")]
		[FieldOffset(Offset = "0x188")]
		private Dictionary<Transform, UIAnimedAvatar.TransCache> m_TmpDynamicBones;

		// Token: 0x04007B52 RID: 31570
		[Token(Token = "0x4007B52")]
		[FieldOffset(Offset = "0x190")]
		private string doubleSpecialanim;

		// Token: 0x04007B53 RID: 31571
		[Token(Token = "0x4007B53")]
		[FieldOffset(Offset = "0x198")]
		private string doubleIdleanim;

		// Token: 0x04007B54 RID: 31572
		[Token(Token = "0x4007B54")]
		[FieldOffset(Offset = "0x1A0")]
		private bool canShowWeapon;

		// Token: 0x04007B55 RID: 31573
		[Token(Token = "0x4007B55")]
		[FieldOffset(Offset = "0x1A1")]
		private bool m_DynamicBonesActive;

		// Token: 0x0200144A RID: 5194
		[Token(Token = "0x200144A")]
		public enum GunType
		{
			// Token: 0x04007B57 RID: 31575
			[Token(Token = "0x4007B57")]
			None,
			// Token: 0x04007B58 RID: 31576
			[Token(Token = "0x4007B58")]
			ShortGun,
			// Token: 0x04007B59 RID: 31577
			[Token(Token = "0x4007B59")]
			ShortGunIdle,
			// Token: 0x04007B5A RID: 31578
			[Token(Token = "0x4007B5A")]
			BigGun,
			// Token: 0x04007B5B RID: 31579
			[Token(Token = "0x4007B5B")]
			BigGunIdle,
			// Token: 0x04007B5C RID: 31580
			[Token(Token = "0x4007B5C")]
			SmallGun,
			// Token: 0x04007B5D RID: 31581
			[Token(Token = "0x4007B5D")]
			SmallGunIdle,
			// Token: 0x04007B5E RID: 31582
			[Token(Token = "0x4007B5E")]
			Grenade,
			// Token: 0x04007B5F RID: 31583
			[Token(Token = "0x4007B5F")]
			GrenadeIdle,
			// Token: 0x04007B60 RID: 31584
			[Token(Token = "0x4007B60")]
			ShotGun,
			// Token: 0x04007B61 RID: 31585
			[Token(Token = "0x4007B61")]
			ShotGunIdle,
			// Token: 0x04007B62 RID: 31586
			[Token(Token = "0x4007B62")]
			Gatling,
			// Token: 0x04007B63 RID: 31587
			[Token(Token = "0x4007B63")]
			GatlingIdle,
			// Token: 0x04007B64 RID: 31588
			[Token(Token = "0x4007B64")]
			Fist,
			// Token: 0x04007B65 RID: 31589
			[Token(Token = "0x4007B65")]
			FistAttack
		}

		// Token: 0x0200144B RID: 5195
		[Token(Token = "0x200144B")]
		private class TransCache
		{
			// Token: 0x06005718 RID: 22296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005718")]
			[Address(RVA = "0x1B0F6E0", Offset = "0x1B0F6E0", VA = "0x7BBC30F6E0")]
			public TransCache(Transform tr)
			{
			}

			// Token: 0x06005719 RID: 22297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005719")]
			[Address(RVA = "0x1B0F7A8", Offset = "0x1B0F7A8", VA = "0x7BBC30F7A8")]
			public void Apply(Transform tr)
			{
			}

			// Token: 0x04007B66 RID: 31590
			[Token(Token = "0x4007B66")]
			[FieldOffset(Offset = "0x10")]
			public Transform Parent;

			// Token: 0x04007B67 RID: 31591
			[Token(Token = "0x4007B67")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 Pos;

			// Token: 0x04007B68 RID: 31592
			[Token(Token = "0x4007B68")]
			[FieldOffset(Offset = "0x24")]
			public Vector3 Scale;

			// Token: 0x04007B69 RID: 31593
			[Token(Token = "0x4007B69")]
			[FieldOffset(Offset = "0x30")]
			public Quaternion Rot;
		}

		// Token: 0x0200144C RID: 5196
		[Token(Token = "0x200144C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECB30", Offset = "0x10ECB30")]
		private sealed class <CoPlayAnimClipAtLobby>d__76 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600571A RID: 22298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600571A")]
			[Address(RVA = "0x1B0EEBC", Offset = "0x1B0EEBC", VA = "0x7BBC30EEBC")]
			[DebuggerHidden]
			public <CoPlayAnimClipAtLobby>d__76(int <>1__state)
			{
			}

			// Token: 0x0600571B RID: 22299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600571B")]
			[Address(RVA = "0x1B0EEE8", Offset = "0x1B0EEE8", VA = "0x7BBC30EEE8", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x0600571C RID: 22300 RVA: 0x00019CC8 File Offset: 0x00017EC8
			[Token(Token = "0x600571C")]
			[Address(RVA = "0x1B0EEEC", Offset = "0x1B0EEEC", VA = "0x7BBC30EEEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x0600571D RID: 22301 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000892")]
			private object Current
			{
				[Token(Token = "0x600571D")]
				[Address(RVA = "0x1B0F0CC", Offset = "0x1B0F0CC", VA = "0x7BBC30F0CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600571E RID: 22302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600571E")]
			[Address(RVA = "0x1B0F0D4", Offset = "0x1B0F0D4", VA = "0x7BBC30F0D4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000893 RID: 2195
			// (get) Token: 0x0600571F RID: 22303 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000893")]
			private object Current
			{
				[Token(Token = "0x600571F")]
				[Address(RVA = "0x1B0F13C", Offset = "0x1B0F13C", VA = "0x7BBC30F13C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007B6A RID: 31594
			[Token(Token = "0x4007B6A")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007B6B RID: 31595
			[Token(Token = "0x4007B6B")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007B6C RID: 31596
			[Token(Token = "0x4007B6C")]
			[FieldOffset(Offset = "0x20")]
			public UIAnimedAvatar <>4__this;

			// Token: 0x04007B6D RID: 31597
			[Token(Token = "0x4007B6D")]
			[FieldOffset(Offset = "0x28")]
			public ResourceID resId;

			// Token: 0x04007B6E RID: 31598
			[Token(Token = "0x4007B6E")]
			[FieldOffset(Offset = "0x2C")]
			public bool loop;
		}

		// Token: 0x0200144D RID: 5197
		[Token(Token = "0x200144D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECB40", Offset = "0x10ECB40")]
		private sealed class <CoPlayEmotionAnimationd>d__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005720 RID: 22304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005720")]
			[Address(RVA = "0x1B0F144", Offset = "0x1B0F144", VA = "0x7BBC30F144")]
			[DebuggerHidden]
			public <CoPlayEmotionAnimationd>d__80(int <>1__state)
			{
			}

			// Token: 0x06005721 RID: 22305 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005721")]
			[Address(RVA = "0x1B0F170", Offset = "0x1B0F170", VA = "0x7BBC30F170", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005722 RID: 22306 RVA: 0x00019CE0 File Offset: 0x00017EE0
			[Token(Token = "0x6005722")]
			[Address(RVA = "0x1B0F174", Offset = "0x1B0F174", VA = "0x7BBC30F174", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000894 RID: 2196
			// (get) Token: 0x06005723 RID: 22307 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000894")]
			private object Current
			{
				[Token(Token = "0x6005723")]
				[Address(RVA = "0x1B0F3D4", Offset = "0x1B0F3D4", VA = "0x7BBC30F3D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005724 RID: 22308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005724")]
			[Address(RVA = "0x1B0F3DC", Offset = "0x1B0F3DC", VA = "0x7BBC30F3DC", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000895 RID: 2197
			// (get) Token: 0x06005725 RID: 22309 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000895")]
			private object Current
			{
				[Token(Token = "0x6005725")]
				[Address(RVA = "0x1B0F444", Offset = "0x1B0F444", VA = "0x7BBC30F444", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007B6F RID: 31599
			[Token(Token = "0x4007B6F")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007B70 RID: 31600
			[Token(Token = "0x4007B70")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007B71 RID: 31601
			[Token(Token = "0x4007B71")]
			[FieldOffset(Offset = "0x20")]
			public UIAnimedAvatar <>4__this;

			// Token: 0x04007B72 RID: 31602
			[Token(Token = "0x4007B72")]
			[FieldOffset(Offset = "0x28")]
			public uint emotionID;

			// Token: 0x04007B73 RID: 31603
			[Token(Token = "0x4007B73")]
			[FieldOffset(Offset = "0x2C")]
			public bool loop;
		}

		// Token: 0x0200144E RID: 5198
		[Token(Token = "0x200144E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECB50", Offset = "0x10ECB50")]
		private sealed class <PlayGunCoroutine>d__83 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005726 RID: 22310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005726")]
			[Address(RVA = "0x1B0F44C", Offset = "0x1B0F44C", VA = "0x7BBC30F44C")]
			[DebuggerHidden]
			public <PlayGunCoroutine>d__83(int <>1__state)
			{
			}

			// Token: 0x06005727 RID: 22311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005727")]
			[Address(RVA = "0x1B0F478", Offset = "0x1B0F478", VA = "0x7BBC30F478", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005728 RID: 22312 RVA: 0x00019CF8 File Offset: 0x00017EF8
			[Token(Token = "0x6005728")]
			[Address(RVA = "0x1B0F47C", Offset = "0x1B0F47C", VA = "0x7BBC30F47C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000896 RID: 2198
			// (get) Token: 0x06005729 RID: 22313 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000896")]
			private object Current
			{
				[Token(Token = "0x6005729")]
				[Address(RVA = "0x1B0F4F0", Offset = "0x1B0F4F0", VA = "0x7BBC30F4F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x0600572A RID: 22314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600572A")]
			[Address(RVA = "0x1B0F4F8", Offset = "0x1B0F4F8", VA = "0x7BBC30F4F8", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000897 RID: 2199
			// (get) Token: 0x0600572B RID: 22315 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000897")]
			private object Current
			{
				[Token(Token = "0x600572B")]
				[Address(RVA = "0x1B0F560", Offset = "0x1B0F560", VA = "0x7BBC30F560", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007B74 RID: 31604
			[Token(Token = "0x4007B74")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007B75 RID: 31605
			[Token(Token = "0x4007B75")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007B76 RID: 31606
			[Token(Token = "0x4007B76")]
			[FieldOffset(Offset = "0x20")]
			public UIAnimedAvatar <>4__this;

			// Token: 0x04007B77 RID: 31607
			[Token(Token = "0x4007B77")]
			[FieldOffset(Offset = "0x28")]
			public UIAnimedAvatar.GunType type;
		}

		// Token: 0x0200144F RID: 5199
		[Token(Token = "0x200144F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECB60", Offset = "0x10ECB60")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600572D RID: 22317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600572D")]
			[Address(RVA = "0x1B0EB5C", Offset = "0x1B0EB5C", VA = "0x7BBC30EB5C")]
			public <>c()
			{
			}

			// Token: 0x0600572E RID: 22318 RVA: 0x00019D10 File Offset: 0x00017F10
			[Token(Token = "0x600572E")]
			[Address(RVA = "0x1B0EB64", Offset = "0x1B0EB64", VA = "0x7BBC30EB64")]
			internal bool <StartShowPose>b__95_0(AnimationClip s)
			{
				return default(bool);
			}

			// Token: 0x0600572F RID: 22319 RVA: 0x00019D28 File Offset: 0x00017F28
			[Token(Token = "0x600572F")]
			[Address(RVA = "0x1B0EBDC", Offset = "0x1B0EBDC", VA = "0x7BBC30EBDC")]
			internal bool <InitGunShowTime>b__157_0(AnimationClip s)
			{
				return default(bool);
			}

			// Token: 0x06005730 RID: 22320 RVA: 0x00019D40 File Offset: 0x00017F40
			[Token(Token = "0x6005730")]
			[Address(RVA = "0x1B0EC94", Offset = "0x1B0EC94", VA = "0x7BBC30EC94")]
			internal bool <InitGunShowTime>b__157_1(AnimationClip s)
			{
				return default(bool);
			}

			// Token: 0x06005731 RID: 22321 RVA: 0x00019D58 File Offset: 0x00017F58
			[Token(Token = "0x6005731")]
			[Address(RVA = "0x1B0ED4C", Offset = "0x1B0ED4C", VA = "0x7BBC30ED4C")]
			internal bool <InitGunShowTime>b__157_2(AnimationClip s)
			{
				return default(bool);
			}

			// Token: 0x06005732 RID: 22322 RVA: 0x00019D70 File Offset: 0x00017F70
			[Token(Token = "0x6005732")]
			[Address(RVA = "0x1B0EE04", Offset = "0x1B0EE04", VA = "0x7BBC30EE04")]
			internal bool <InitGunShowTime>b__157_3(AnimationClip s)
			{
				return default(bool);
			}

			// Token: 0x04007B78 RID: 31608
			[Token(Token = "0x4007B78")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIAnimedAvatar.<>c <>9;

			// Token: 0x04007B79 RID: 31609
			[Token(Token = "0x4007B79")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<AnimationClip> <>9__95_0;

			// Token: 0x04007B7A RID: 31610
			[Token(Token = "0x4007B7A")]
			[FieldOffset(Offset = "0x10")]
			public static Predicate<AnimationClip> <>9__157_0;

			// Token: 0x04007B7B RID: 31611
			[Token(Token = "0x4007B7B")]
			[FieldOffset(Offset = "0x18")]
			public static Predicate<AnimationClip> <>9__157_1;

			// Token: 0x04007B7C RID: 31612
			[Token(Token = "0x4007B7C")]
			[FieldOffset(Offset = "0x20")]
			public static Predicate<AnimationClip> <>9__157_2;

			// Token: 0x04007B7D RID: 31613
			[Token(Token = "0x4007B7D")]
			[FieldOffset(Offset = "0x28")]
			public static Predicate<AnimationClip> <>9__157_3;
		}

		// Token: 0x02001450 RID: 5200
		[Token(Token = "0x2001450")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECB70", Offset = "0x10ECB70")]
		private sealed class <SetGunAnimTrigger>d__142 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06005733 RID: 22323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005733")]
			[Address(RVA = "0x1B0F568", Offset = "0x1B0F568", VA = "0x7BBC30F568")]
			[DebuggerHidden]
			public <SetGunAnimTrigger>d__142(int <>1__state)
			{
			}

			// Token: 0x06005734 RID: 22324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005734")]
			[Address(RVA = "0x1B0F594", Offset = "0x1B0F594", VA = "0x7BBC30F594", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005735 RID: 22325 RVA: 0x00019D88 File Offset: 0x00017F88
			[Token(Token = "0x6005735")]
			[Address(RVA = "0x1B0F598", Offset = "0x1B0F598", VA = "0x7BBC30F598", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000898 RID: 2200
			// (get) Token: 0x06005736 RID: 22326 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000898")]
			private object Current
			{
				[Token(Token = "0x6005736")]
				[Address(RVA = "0x1B0F668", Offset = "0x1B0F668", VA = "0x7BBC30F668", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005737 RID: 22327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005737")]
			[Address(RVA = "0x1B0F670", Offset = "0x1B0F670", VA = "0x7BBC30F670", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000899 RID: 2201
			// (get) Token: 0x06005738 RID: 22328 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000899")]
			private object Current
			{
				[Token(Token = "0x6005738")]
				[Address(RVA = "0x1B0F6D8", Offset = "0x1B0F6D8", VA = "0x7BBC30F6D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007B7E RID: 31614
			[Token(Token = "0x4007B7E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007B7F RID: 31615
			[Token(Token = "0x4007B7F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007B80 RID: 31616
			[Token(Token = "0x4007B80")]
			[FieldOffset(Offset = "0x20")]
			public UIAnimedAvatar <>4__this;

			// Token: 0x04007B81 RID: 31617
			[Token(Token = "0x4007B81")]
			[FieldOffset(Offset = "0x28")]
			public UIAnimedAvatar.GunType type;
		}
	}
}
