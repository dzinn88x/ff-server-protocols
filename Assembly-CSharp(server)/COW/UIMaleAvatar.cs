using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001443 RID: 5187
	[Token(Token = "0x2001443")]
	public class UIMaleAvatar : UIStatedAvatar
	{
		// Token: 0x06005624 RID: 22052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005624")]
		[Address(RVA = "0x1CD481C", Offset = "0x1CD481C", VA = "0x7BBC4D481C")]
		public static UIMaleAvatar GetLocalAvatar()
		{
			return null;
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005625")]
		[Address(RVA = "0x1CE5F1C", Offset = "0x1CE5F1C", VA = "0x7BBC4E5F1C")]
		private static void SetLocalAvatar(UIMaleAvatar s)
		{
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005626")]
		[Address(RVA = "0x1CE60BC", Offset = "0x1CE60BC", VA = "0x7BBC4E60BC")]
		public static UIMaleAvatar CreateAvatar(bool female)
		{
			return null;
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005627")]
		[Address(RVA = "0x1CE61D0", Offset = "0x1CE61D0", VA = "0x7BBC4E61D0", Slot = "20")]
		public override void InitAvatar(bool isLocal, bool isPreviewAvatar = false, int textureScale = 1)
		{
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005628")]
		[Address(RVA = "0x1CE6438", Offset = "0x1CE6438", VA = "0x7BBC4E6438")]
		private void OnDisable()
		{
		}

		// Token: 0x06005629 RID: 22057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005629")]
		[Address(RVA = "0x1CE6444", Offset = "0x1CE6444", VA = "0x7BBC4E6444")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562A")]
		[Address(RVA = "0x1CE651C", Offset = "0x1CE651C", VA = "0x7BBC4E651C")]
		private void OnQualityChanged(object[] data)
		{
		}

		// Token: 0x0600562B RID: 22059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562B")]
		[Address(RVA = "0x1CE6524", Offset = "0x1CE6524", VA = "0x7BBC4E6524")]
		public void SetLightVisble(bool isVisble)
		{
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562C")]
		[Address(RVA = "0x1CE65D4", Offset = "0x1CE65D4", VA = "0x7BBC4E65D4")]
		public void SetLightLayer(int layer)
		{
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562D")]
		[Address(RVA = "0x1CE66C8", Offset = "0x1CE66C8", VA = "0x7BBC4E66C8")]
		public void SetCastShadow(bool castShadow)
		{
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562E")]
		[Address(RVA = "0x1CE67A8", Offset = "0x1CE67A8", VA = "0x7BBC4E67A8")]
		public void SetAvatarPlaneShow(bool isShow)
		{
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562F")]
		[Address(RVA = "0x1CE634C", Offset = "0x1CE634C", VA = "0x7BBC4E634C")]
		private void InitPlaneGo()
		{
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005630")]
		[Address(RVA = "0x1CE6858", Offset = "0x1CE6858", VA = "0x7BBC4E6858")]
		public void StartShowGachaPose()
		{
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005631")]
		[Address(RVA = "0x1CE685C", Offset = "0x1CE685C", VA = "0x7BBC4E685C")]
		public void SetAvatarData(UIModelAvatarBase.AvatarData aData, uint collectionid = 0U)
		{
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005632")]
		[Address(RVA = "0x1CD48E0", Offset = "0x1CD48E0", VA = "0x7BBC4D48E0")]
		public void OnClothUpdate(params object[] data)
		{
		}

		// Token: 0x06005633 RID: 22067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005633")]
		[Address(RVA = "0x1CE697C", Offset = "0x1CE697C", VA = "0x7BBC4E697C")]
		public void ResetToModelCurrentAvatar(bool resetcollection = true)
		{
		}

		// Token: 0x06005634 RID: 22068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005634")]
		[Address(RVA = "0x1CE6A4C", Offset = "0x1CE6A4C", VA = "0x7BBC4E6A4C")]
		public void InitMatchResultAnim(bool win, bool hasWeapon, bool isKnife, UIAnimedAvatar.GunType gunType)
		{
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005635")]
		[Address(RVA = "0x1CE6C54", Offset = "0x1CE6C54", VA = "0x7BBC4E6C54")]
		public void PlayMatchResultAnim()
		{
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005636")]
		[Address(RVA = "0x1CE6CF4", Offset = "0x1CE6CF4", VA = "0x7BBC4E6CF4")]
		public void PlayMVPAnim()
		{
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005637")]
		[Address(RVA = "0x1CE6D48", Offset = "0x1CE6D48", VA = "0x7BBC4E6D48")]
		public void SkipMVPAnim()
		{
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005638")]
		[Address(RVA = "0x1CE6C80", Offset = "0x1CE6C80", VA = "0x7BBC4E6C80")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x113EC94", Offset = "0x113EC94")]
		private IEnumerator SetMatchResultAnimState()
		{
			return null;
		}

		// Token: 0x06005639 RID: 22073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005639")]
		[Address(RVA = "0x1CE6E44", Offset = "0x1CE6E44", VA = "0x7BBC4E6E44")]
		private void UpdateMatchResultAnim()
		{
		}

		// Token: 0x0600563A RID: 22074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600563A")]
		[Address(RVA = "0x1CE6F98", Offset = "0x1CE6F98", VA = "0x7BBC4E6F98", Slot = "35")]
		protected override void DoUpdate()
		{
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600563B")]
		[Address(RVA = "0x1CE6FAC", Offset = "0x1CE6FAC", VA = "0x7BBC4E6FAC")]
		public void UpdateNoAnimWeaponOnHand(uint weaponId)
		{
		}

		// Token: 0x0600563C RID: 22076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600563C")]
		[Address(RVA = "0x1CE7100", Offset = "0x1CE7100", VA = "0x7BBC4E7100")]
		public void SetAvatarForward(bool isForward)
		{
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600563D")]
		[Address(RVA = "0x1CE71F4", Offset = "0x1CE71F4", VA = "0x7BBC4E71F4")]
		public UIMaleAvatar()
		{
		}

		// Token: 0x04007AF0 RID: 31472
		[Token(Token = "0x4007AF0")]
		[FieldOffset(Offset = "0x0")]
		public static UIMaleAvatar LocalAvatar;

		// Token: 0x04007AF1 RID: 31473
		[Token(Token = "0x4007AF1")]
		[FieldOffset(Offset = "0x1F8")]
		private GameObject m_PlaneGO;

		// Token: 0x04007AF2 RID: 31474
		[Token(Token = "0x4007AF2")]
		private const float MATCHRESULT_WAIT_ANIM_TIME = 2f;

		// Token: 0x04007AF3 RID: 31475
		[Token(Token = "0x4007AF3")]
		private const float MATCHRESULT_STAND_ANIM_TIME = 8f;

		// Token: 0x04007AF4 RID: 31476
		[Token(Token = "0x4007AF4")]
		[FieldOffset(Offset = "0x200")]
		private float m_MatchResultPlayTime;

		// Token: 0x04007AF5 RID: 31477
		[Token(Token = "0x4007AF5")]
		[FieldOffset(Offset = "0x204")]
		private bool m_IsPlayMatchResultShow;

		// Token: 0x04007AF6 RID: 31478
		[Token(Token = "0x4007AF6")]
		[FieldOffset(Offset = "0x205")]
		private bool m_MatchResultNeedSwapAnim;

		// Token: 0x04007AF7 RID: 31479
		[Token(Token = "0x4007AF7")]
		[FieldOffset(Offset = "0x208")]
		private float m_MatchResutlAnimSwapTime;

		// Token: 0x04007AF8 RID: 31480
		[Token(Token = "0x4007AF8")]
		[FieldOffset(Offset = "0x20C")]
		private UIAnimedAvatar.GunType m_MatchResultGunType;

		// Token: 0x02001444 RID: 5188
		[Token(Token = "0x2001444")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10ECB10", Offset = "0x10ECB10")]
		private sealed class <SetMatchResultAnimState>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x0600563E RID: 22078 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600563E")]
			[Address(RVA = "0x1CE6E18", Offset = "0x1CE6E18", VA = "0x7BBC4E6E18")]
			[DebuggerHidden]
			public <SetMatchResultAnimState>d__29(int <>1__state)
			{
			}

			// Token: 0x0600563F RID: 22079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600563F")]
			[Address(RVA = "0x1CE71FC", Offset = "0x1CE71FC", VA = "0x7BBC4E71FC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x06005640 RID: 22080 RVA: 0x00019A28 File Offset: 0x00017C28
			[Token(Token = "0x6005640")]
			[Address(RVA = "0x1CE7200", Offset = "0x1CE7200", VA = "0x7BBC4E7200", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x17000886 RID: 2182
			// (get) Token: 0x06005641 RID: 22081 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000886")]
			private object Current
			{
				[Token(Token = "0x6005641")]
				[Address(RVA = "0x1CE7498", Offset = "0x1CE7498", VA = "0x7BBC4E7498", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x06005642 RID: 22082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005642")]
			[Address(RVA = "0x1CE74A0", Offset = "0x1CE74A0", VA = "0x7BBC4E74A0", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x17000887 RID: 2183
			// (get) Token: 0x06005643 RID: 22083 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000887")]
			private object Current
			{
				[Token(Token = "0x6005643")]
				[Address(RVA = "0x1CE7508", Offset = "0x1CE7508", VA = "0x7BBC4E7508", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x04007AF9 RID: 31481
			[Token(Token = "0x4007AF9")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04007AFA RID: 31482
			[Token(Token = "0x4007AFA")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04007AFB RID: 31483
			[Token(Token = "0x4007AFB")]
			[FieldOffset(Offset = "0x20")]
			public UIMaleAvatar <>4__this;
		}
	}
}
