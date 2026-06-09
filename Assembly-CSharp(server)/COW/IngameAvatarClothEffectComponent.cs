using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UMA;
using UnityEngine;

namespace COW
{
	// Token: 0x02001260 RID: 4704
	[Token(Token = "0x2001260")]
	internal class IngameAvatarClothEffectComponent : MonoBehaviour
	{
		// Token: 0x060048D7 RID: 18647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D7")]
		[Address(RVA = "0x185D634", Offset = "0x185D634", VA = "0x7BBC05D634")]
		private void Start()
		{
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D8")]
		[Address(RVA = "0x185D6D4", Offset = "0x185D6D4", VA = "0x7BBC05D6D4")]
		public void PlayIngameAnimEffect(GameObject prefab, UIModelAvatarBase.EWardrobeType wType, bool isPrefab = true, [Optional] List<GameObject> gos)
		{
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D9")]
		[Address(RVA = "0x185DB1C", Offset = "0x185DB1C", VA = "0x7BBC05DB1C")]
		private void ProcessBoneNameRefsIngame(GameObject go, UIModelAvatarBase.EWardrobeType wType, [Optional] List<GameObject> gos)
		{
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048DA")]
		[Address(RVA = "0x185E1D0", Offset = "0x185E1D0", VA = "0x7BBC05E1D0")]
		public void SetAnimEffectVisibility(BitArrayBoolean visible, UIModelAvatarBase.EWardrobeType wType)
		{
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048DB")]
		[Address(RVA = "0x185E354", Offset = "0x185E354", VA = "0x7BBC05E354")]
		public void ChangeMeshLayer(int layer)
		{
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048DC")]
		[Address(RVA = "0x185E65C", Offset = "0x185E65C", VA = "0x7BBC05E65C")]
		public void RemoveAnimEffect(UIModelAvatarBase.EWardrobeType wType)
		{
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x000161B8 File Offset: 0x000143B8
		[Token(Token = "0x60048DD")]
		[Address(RVA = "0x185E0C4", Offset = "0x185E0C4", VA = "0x7BBC05E0C4")]
		private static bool ScaleInLocalSpace(GameObject o)
		{
			return default(bool);
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x000161D0 File Offset: 0x000143D0
		[Token(Token = "0x60048DE")]
		[Address(RVA = "0x185E800", Offset = "0x185E800", VA = "0x7BBC05E800")]
		public bool StartDynamicEffect(int id, ResourceID res)
		{
			return default(bool);
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048DF")]
		[Address(RVA = "0x185EBB8", Offset = "0x185EBB8", VA = "0x7BBC05EBB8")]
		public void StopDynamicEffect(int id, ResourceID res)
		{
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E0")]
		[Address(RVA = "0x185F1B4", Offset = "0x185F1B4", VA = "0x7BBC05F1B4")]
		public void SetDynamicEffectVisibility(int id, bool visible)
		{
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E1")]
		[Address(RVA = "0x185EA94", Offset = "0x185EA94", VA = "0x7BBC05EA94")]
		private void StartEffects(List<GameObject> list, bool start)
		{
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E2")]
		[Address(RVA = "0x185EF78", Offset = "0x185EF78", VA = "0x7BBC05EF78")]
		private void StartEffects(GameObject go, bool start)
		{
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E3")]
		[Address(RVA = "0x185F4D8", Offset = "0x185F4D8", VA = "0x7BBC05F4D8")]
		private void StartAnims(List<GameObject> list, bool start)
		{
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E4")]
		[Address(RVA = "0x185F2FC", Offset = "0x185F2FC", VA = "0x7BBC05F2FC")]
		private void EnableRenderers(GameObject go, bool enable)
		{
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048E5")]
		[Address(RVA = "0x185F6DC", Offset = "0x185F6DC", VA = "0x7BBC05F6DC")]
		public IngameAvatarClothEffectComponent()
		{
		}

		// Token: 0x040071CB RID: 29131
		[Token(Token = "0x40071CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IUmaAvatar m_Avatar;

		// Token: 0x040071CC RID: 29132
		[Token(Token = "0x40071CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<UIModelAvatarBase.EWardrobeType, List<GameObject>> m_ClothEffectDict;

		// Token: 0x040071CD RID: 29133
		[Token(Token = "0x40071CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool PoolDynamicEffects;

		// Token: 0x040071CE RID: 29134
		[Token(Token = "0x40071CE")]
		private const bool AllowsAnimationInDynamicEffects = false;

		// Token: 0x040071CF RID: 29135
		[Token(Token = "0x40071CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<int, List<GameObject>> m_DynamicEffects;

		// Token: 0x040071D0 RID: 29136
		[Token(Token = "0x40071D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ParticleSystem> s_SharedTmpParticlesList;

		// Token: 0x040071D1 RID: 29137
		[Token(Token = "0x40071D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<Renderer> s_SharedTmpRenderList;
	}
}
