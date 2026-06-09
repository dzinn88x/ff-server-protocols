using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW
{
	// Token: 0x02001440 RID: 5184
	[Token(Token = "0x2001440")]
	public class LobbyAvatarClothEffectComponent : MonoBehaviour
	{
		// Token: 0x06005615 RID: 22037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005615")]
		[Address(RVA = "0x1406B80", Offset = "0x1406B80", VA = "0x7BBBC06B80")]
		private void Awake()
		{
		}

		// Token: 0x06005616 RID: 22038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005616")]
		[Address(RVA = "0x1406BF0", Offset = "0x1406BF0", VA = "0x7BBBC06BF0")]
		public void PlayLobbyAnimEffect(GameObject prefab, EffectObject eObject)
		{
		}

		// Token: 0x06005617 RID: 22039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005617")]
		[Address(RVA = "0x1406EBC", Offset = "0x1406EBC", VA = "0x7BBBC06EBC")]
		private void ProcessBoneNameRefs(GameObject go, EffectObject eObject)
		{
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005618")]
		[Address(RVA = "0x14076F4", Offset = "0x14076F4", VA = "0x7BBBC076F4")]
		public void SetEventEffectsVisibility(bool isVisible, bool allEventEffects = true)
		{
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x000199E0 File Offset: 0x00017BE0
		[Token(Token = "0x6005619")]
		[Address(RVA = "0x14075E8", Offset = "0x14075E8", VA = "0x7BBBC075E8")]
		private static bool ScaleInLocalSpace(GameObject o)
		{
			return default(bool);
		}

		// Token: 0x0600561A RID: 22042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561A")]
		[Address(RVA = "0x14078B8", Offset = "0x14078B8", VA = "0x7BBBC078B8")]
		public void StopAnimEfects()
		{
		}

		// Token: 0x0600561B RID: 22043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600561B")]
		[Address(RVA = "0x1407AA8", Offset = "0x1407AA8", VA = "0x7BBBC07AA8")]
		public LobbyAvatarClothEffectComponent()
		{
		}

		// Token: 0x04007AD7 RID: 31447
		[Token(Token = "0x4007AD7")]
		[FieldOffset(Offset = "0x18")]
		private IUmaAvatar m_Avatar;

		// Token: 0x04007AD8 RID: 31448
		[Token(Token = "0x4007AD8")]
		[FieldOffset(Offset = "0x20")]
		private List<GameObject> m_AnimEffects;

		// Token: 0x04007AD9 RID: 31449
		[Token(Token = "0x4007AD9")]
		[FieldOffset(Offset = "0x28")]
		private List<EffectObject> m_EventEffects;
	}
}
