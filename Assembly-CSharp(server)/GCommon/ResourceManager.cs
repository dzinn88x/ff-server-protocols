using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using COW.GamePlay;
using Il2CppDummyDll;
using LitJson;
using TsiU;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GCommon
{
	// Token: 0x02000FF5 RID: 4085
	[Token(Token = "0x2000FF5")]
	public class ResourceManager : TSingleton<ResourceManager>
	{
		// Token: 0x06003C9F RID: 15519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C9F")]
		[Address(RVA = "0x2481C74", Offset = "0x2481C74", VA = "0x7BBCC81C74")]
		public void SetResQualityLevel(GGfm}Dt q)
		{
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x00012F78 File Offset: 0x00011178
		[Token(Token = "0x6003CA0")]
		[Address(RVA = "0x2481C7C", Offset = "0x2481C7C", VA = "0x7BBCC81C7C")]
		public GGfm}Dt GetResQualityLevel()
		{
			return GGfm}Dt.High;
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x00012F90 File Offset: 0x00011190
		[Token(Token = "0x6003CA1")]
		[Address(RVA = "0x2481C84", Offset = "0x2481C84", VA = "0x7BBCC81C84")]
		public bool Init(bool useAssetBundle, [Optional] string[] dontDestoryResources)
		{
			return default(bool);
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06003CA2 RID: 15522 RVA: 0x00012FA8 File Offset: 0x000111A8
		[Token(Token = "0x17000718")]
		public bool Inited
		{
			[Token(Token = "0x6003CA2")]
			[Address(RVA = "0x2481FB4", Offset = "0x2481FB4", VA = "0x7BBCC81FB4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003CA3 RID: 15523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA3")]
		[Address(RVA = "0x2481FBC", Offset = "0x2481FBC", VA = "0x7BBCC81FBC")]
		public void Cleanup()
		{
		}

		// Token: 0x06003CA4 RID: 15524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA4")]
		[Address(RVA = "0x2481F34", Offset = "0x2481F34", VA = "0x7BBCC81F34")]
		public void LoadPersisitResource()
		{
		}

		// Token: 0x06003CA5 RID: 15525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA5")]
		[Address(RVA = "0x2483038", Offset = "0x2483038", VA = "0x7BBCC83038")]
		public void SwapAndReleaseAnoymousMappingTmp()
		{
		}

		// Token: 0x06003CA6 RID: 15526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA6")]
		[Address(RVA = "0x2482F14", Offset = "0x2482F14", VA = "0x7BBCC82F14")]
		private void LoadDontDestoryResource(string resPath)
		{
		}

		// Token: 0x06003CA7 RID: 15527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0x2483508", Offset = "0x2483508", VA = "0x7BBCC83508")]
		public UnityEngine.Object PoolGetRes(ResourceID id, [Optional] Transform tranformParent)
		{
			return null;
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x00012FC0 File Offset: 0x000111C0
		[Token(Token = "0x6003CA8")]
		[Address(RVA = "0x2483580", Offset = "0x2483580", VA = "0x7BBCC83580")]
		public bool PoolReturnRes(ResourceID id, UnityEngine.Object obj, bool worldPositionStays = true)
		{
			return default(bool);
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0x2483600", Offset = "0x2483600", VA = "0x7BBCC83600")]
		public string GetResourceAbName(ResourceID id)
		{
			return null;
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x2483768", Offset = "0x2483768", VA = "0x7BBCC83768")]
		public string GetResourceStreamAbName(ResourceID id)
		{
			return null;
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x248382C", Offset = "0x248382C", VA = "0x7BBCC8382C")]
		public UnityEngine.Object GetResource(ResourceID id, bool notUsingABForcefully = false, [Optional] Type type, bool noCache = false)
		{
			return null;
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAC")]
		[Address(RVA = "0x2483E80", Offset = "0x2483E80", VA = "0x7BBCC83E80")]
		public UnityEngine.Object GetResource(string resPath, bool notUsingABForcefully = false, bool noCache = false)
		{
			return null;
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAD")]
		[Address(RVA = "0x2483AE0", Offset = "0x2483AE0", VA = "0x7BBCC83AE0")]
		private UnityEngine.Object GetResource(string resPath, ResourceManager.ELoadAbOption abOpt, string ab = "", [Optional] Type type, bool noCache = false)
		{
			return null;
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAE")]
		[Address(RVA = "0x2483F04", Offset = "0x2483F04", VA = "0x7BBCC83F04")]
		private UnityEngine.Object GetResourceInternalFull(string resPath, bool notUsingABForcefully = false, bool dontDestroy = false, bool isDependency = false)
		{
			return null;
		}

		// Token: 0x06003CAF RID: 15535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAF")]
		[Address(RVA = "0x24830A8", Offset = "0x24830A8", VA = "0x7BBCC830A8")]
		private UnityEngine.Object GetResourceInternal(string resPath, ResourceManager.ELoadAbOption abOpt = ResourceManager.ELoadAbOption.NotAb, string abPath = "", bool dontDestroy = false, [Optional] Type type, bool noCache = false)
		{
			return null;
		}

		// Token: 0x06003CB0 RID: 15536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB0")]
		[Address(RVA = "0x2484684", Offset = "0x2484684", VA = "0x7BBCC84684")]
		private AssetBundle LoadABImpl(string abPath)
		{
			return null;
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB1")]
		[Address(RVA = "0x24841FC", Offset = "0x24841FC", VA = "0x7BBCC841FC")]
		public AssetBundle LoadABWithoutLoadingAssets(string resPath, bool dontDestroy)
		{
			return null;
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06003CB2 RID: 15538 RVA: 0x00012FD8 File Offset: 0x000111D8
		[Token(Token = "0x17000719")]
		public int LoadedAbCount
		{
			[Token(Token = "0x6003CB2")]
			[Address(RVA = "0x248487C", Offset = "0x248487C", VA = "0x7BBCC8487C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB3")]
		[Address(RVA = "0x248490C", Offset = "0x248490C", VA = "0x7BBCC8490C")]
		private AssetBundle LoadAssetBundleFromCache(string abPath, bool dontDestroy = false)
		{
			return null;
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB4")]
		[Address(RVA = "0x24849E0", Offset = "0x24849E0", VA = "0x7BBCC849E0")]
		public void RemoveSceneAB(string abPath)
		{
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB5")]
		[Address(RVA = "0x2484B38", Offset = "0x2484B38", VA = "0x7BBCC84B38")]
		public void OnLoadSceneFinish(string scenePath, bool useAB)
		{
		}

		// Token: 0x06003CB6 RID: 15542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB6")]
		[Address(RVA = "0x2484BD4", Offset = "0x2484BD4", VA = "0x7BBCC84BD4")]
		public AsyncOperation StartLoadingSceneAsync(string scenePath, string abPath = "", LoadSceneMode mode = LoadSceneMode.Single, bool notUsingABForcefully = false)
		{
			return null;
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB7")]
		[Address(RVA = "0x2484DE0", Offset = "0x2484DE0", VA = "0x7BBCC84DE0")]
		public AssetBundle LoadSceneABWithoutLoadingAssets(string abPath, bool dontDestroy)
		{
			return null;
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB8")]
		[Address(RVA = "0x2484FD4", Offset = "0x2484FD4", VA = "0x7BBCC84FD4")]
		public static string GetStreamABPathByABPath(string ab_path)
		{
			return null;
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB9")]
		[Address(RVA = "0x2485028", Offset = "0x2485028", VA = "0x7BBCC85028")]
		public string GetSceneStreamABPath(ResourceID id)
		{
			return null;
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x00012FF0 File Offset: 0x000111F0
		[Token(Token = "0x6003CBA")]
		[Address(RVA = "0x24852C4", Offset = "0x24852C4", VA = "0x7BBCC852C4")]
		public bool IsResourceUseAB(ResourceID id, ref string abPath)
		{
			return default(bool);
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x00013008 File Offset: 0x00011208
		[Token(Token = "0x6003CBB")]
		[Address(RVA = "0x2485148", Offset = "0x2485148", VA = "0x7BBCC85148")]
		public bool IsResourceUseStreamAB(ResourceID id, ref string abPath, ref string streamABPath)
		{
			return default(bool);
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CBC")]
		[Address(RVA = "0x248539C", Offset = "0x248539C", VA = "0x7BBCC8539C")]
		public void FinishLoadingScene(ResourceID id)
		{
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBD")]
		[Address(RVA = "0x2485474", Offset = "0x2485474", VA = "0x7BBCC85474")]
		public AsyncOperation StartLoadingSceneAsync(ResourceID id, LoadSceneMode mode = LoadSceneMode.Single, bool notUsingABForcefully = false, bool need_modify = false)
		{
			return null;
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBE")]
		[Address(RVA = "0x2485580", Offset = "0x2485580", VA = "0x7BBCC85580")]
		public AsyncOperation UnloadSceneAsync(ResourceID id)
		{
			return null;
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBF")]
		[Address(RVA = "0x24855EC", Offset = "0x24855EC", VA = "0x7BBCC855EC")]
		public ResourceID[] GetPreloadResource(Enum gametypeormode)
		{
			return null;
		}

		// Token: 0x06003CC0 RID: 15552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC0")]
		[Address(RVA = "0x2485674", Offset = "0x2485674", VA = "0x7BBCC85674")]
		public ResourceID[] GetPreloadAudioResource(Enum gametypeormode)
		{
			return null;
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC1")]
		[Address(RVA = "0x24856FC", Offset = "0x24856FC", VA = "0x7BBCC856FC")]
		public ResourceID[] GetPreloadPlayerAnimatorsResource(int key)
		{
			return null;
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC2")]
		[Address(RVA = "0x2485784", Offset = "0x2485784", VA = "0x7BBCC85784")]
		public string GetPath(ResourceID resourceID, GGfm}Dt rq)
		{
			return null;
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC3")]
		[Address(RVA = "0x24857E0", Offset = "0x24857E0", VA = "0x7BBCC857E0")]
		public string GetPath(ResourceID resourceID)
		{
			return null;
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC4")]
		[Address(RVA = "0x2485834", Offset = "0x2485834", VA = "0x7BBCC85834")]
		public List<ResourceID> GetResourceIDs()
		{
			return null;
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC5")]
		[Address(RVA = "0x248598C", Offset = "0x248598C", VA = "0x7BBCC8598C")]
		public string GetAtlasOrSpriteResourceIDName(ResourceID ResID, bool InLogErr = true)
		{
			return null;
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x00013020 File Offset: 0x00011220
		[Token(Token = "0x6003CC6")]
		[Address(RVA = "0x2485A20", Offset = "0x2485A20", VA = "0x7BBCC85A20")]
		public ResourceID GetResourceIDByName(Type ResID, string strResid, bool InLogErr = true)
		{
			return default(ResourceID);
		}

		// Token: 0x06003CC7 RID: 15559 RVA: 0x00013038 File Offset: 0x00011238
		[Token(Token = "0x6003CC7")]
		[Address(RVA = "0x24845F0", Offset = "0x24845F0", VA = "0x7BBCC845F0")]
		private static bool IsPathWithSuffix(string url)
		{
			return default(bool);
		}

		// Token: 0x06003CC8 RID: 15560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC8")]
		[Address(RVA = "0x2485C48", Offset = "0x2485C48", VA = "0x7BBCC85C48")]
		public AsyncOperation ClearAllLoadedResource(bool includingPreloadResource = true)
		{
			return null;
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CC9")]
		[Address(RVA = "0x2485CE4", Offset = "0x2485CE4", VA = "0x7BBCC85CE4")]
		public void ClearResource(ResourceID id, bool isUnloadAsset = true)
		{
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCA")]
		[Address(RVA = "0x248600C", Offset = "0x248600C", VA = "0x7BBCC8600C")]
		private void ClearResource(ResourceManager.ResourceConfigAB config, bool isUnloadAsset = true)
		{
		}

		// Token: 0x06003CCB RID: 15563 RVA: 0x00013050 File Offset: 0x00011250
		[Token(Token = "0x6003CCB")]
		[Address(RVA = "0x2485E8C", Offset = "0x2485E8C", VA = "0x7BBCC85E8C")]
		public bool ClearResource(string path, bool isUnloadAsset = true)
		{
			return default(bool);
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x00013068 File Offset: 0x00011268
		[Token(Token = "0x6003CCC")]
		[Address(RVA = "0x24862E8", Offset = "0x24862E8", VA = "0x7BBCC862E8")]
		public bool ClearPreLoadedResources(string path)
		{
			return default(bool);
		}

		// Token: 0x06003CCD RID: 15565 RVA: 0x00013080 File Offset: 0x00011280
		[Token(Token = "0x6003CCD")]
		[Address(RVA = "0x2486144", Offset = "0x2486144", VA = "0x7BBCC86144")]
		public bool ClearLoadedResources(string path, bool isUnloadAsset = true)
		{
			return default(bool);
		}

		// Token: 0x06003CCE RID: 15566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCE")]
		[Address(RVA = "0x2486358", Offset = "0x2486358", VA = "0x7BBCC86358")]
		public void ClearAndUnloadLoadedResources(string path)
		{
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CCF")]
		[Address(RVA = "0x2482188", Offset = "0x2482188", VA = "0x7BBCC82188")]
		private void ClearAllLoadedResourceInternal(bool includingPreloadResource)
		{
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD0")]
		[Address(RVA = "0x248646C", Offset = "0x248646C", VA = "0x7BBCC8646C")]
		public void UnloadBundleResourceByPath(string path)
		{
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CD1")]
		[Address(RVA = "0x248656C", Offset = "0x248656C", VA = "0x7BBCC8656C")]
		public void GetPreloadResouce(ResourceID id, out bool is_preloaded, out UnityEngine.Object result)
		{
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD2")]
		[Address(RVA = "0x24868C8", Offset = "0x24868C8", VA = "0x7BBCC868C8")]
		public UnityEngine.Object GetResourceNoCache(ResourceID id)
		{
			return null;
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD3")]
		[Address(RVA = "0x24868DC", Offset = "0x24868DC", VA = "0x7BBCC868DC")]
		public UnityEngine.Object GetResourceByNameAndAb(string resPath, string abPath, bool preload, bool noCache)
		{
			return null;
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CD4")]
		[Address(RVA = "0x2486AE0", Offset = "0x2486AE0", VA = "0x7BBCC86AE0")]
		protected UnityEngine.Object GetResourceNoCache(string path, bool notUsingABForcefully = false)
		{
			return null;
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x00013098 File Offset: 0x00011298
		[Token(Token = "0x6003CD5")]
		[Address(RVA = "0x2486AEC", Offset = "0x2486AEC", VA = "0x7BBCC86AEC")]
		public ResourceID AddPlaceholderResForAb(string ab)
		{
			return default(ResourceID);
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x000130B0 File Offset: 0x000112B0
		[Token(Token = "0x6003CD6")]
		[Address(RVA = "0x248436C", Offset = "0x248436C", VA = "0x7BBCC8436C")]
		private bool LoadResconfDependenciesInNeed(string ab, bool recursive = false)
		{
			return default(bool);
		}

		// Token: 0x06003CD7 RID: 15575 RVA: 0x000130C8 File Offset: 0x000112C8
		[Token(Token = "0x6003CD7")]
		[Address(RVA = "0x2486C08", Offset = "0x2486C08", VA = "0x7BBCC86C08")]
		public bool NeedDownloadOptionalBundle(bool assertInSingleBundle, params ResourceID[] ids)
		{
			return default(bool);
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x000130E0 File Offset: 0x000112E0
		[Token(Token = "0x6003CD8")]
		[Address(RVA = "0x2486D24", Offset = "0x2486D24", VA = "0x7BBCC86D24")]
		public bool NeedDownloadOptionalBundle(ResourceID id)
		{
			return default(bool);
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x000130F8 File Offset: 0x000112F8
		[Token(Token = "0x6003CD9")]
		[Address(RVA = "0x2486E54", Offset = "0x2486E54", VA = "0x7BBCC86E54")]
		public bool NeedDownloadOptionalBundle(string ab)
		{
			return default(bool);
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CDA")]
		[Address(RVA = "0x2487028", Offset = "0x2487028", VA = "0x7BBCC87028")]
		public List<string> GetResourceDependencies(string ab)
		{
			return null;
		}

		// Token: 0x06003CDB RID: 15579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CDB")]
		[Address(RVA = "0x24870B0", Offset = "0x24870B0", VA = "0x7BBCC870B0")]
		public static GameObject Instant(UnityEngine.Object obj, [Optional] Transform parent, bool setPosAndRot = false, [Optional] Vector3 pos, [Optional] Quaternion rot)
		{
			return null;
		}

		// Token: 0x06003CDC RID: 15580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CDC")]
		[Address(RVA = "0x24872F0", Offset = "0x24872F0", VA = "0x7BBCC872F0")]
		public static GameObject InstantByResId(ResourceID resId, [Optional] Transform parent, bool setPosAndRot = false, [Optional] Vector3 pos, [Optional] Quaternion rot)
		{
			return null;
		}

		// Token: 0x06003CDD RID: 15581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDD")]
		[Address(RVA = "0x248747C", Offset = "0x248747C", VA = "0x7BBCC8747C")]
		public void UnloadSplashTexture()
		{
		}

		// Token: 0x06003CDE RID: 15582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CDE")]
		[Address(RVA = "0x24875D8", Offset = "0x24875D8", VA = "0x7BBCC875D8")]
		public ResourceRefCache CreateRefCache()
		{
			return null;
		}

		// Token: 0x06003CDF RID: 15583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CDF")]
		[Address(RVA = "0x24876D4", Offset = "0x24876D4", VA = "0x7BBCC876D4")]
		public void ReleaseRefCache(ResourceRefCache cache)
		{
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x00013110 File Offset: 0x00011310
		[Token(Token = "0x6003CE0")]
		[Address(RVA = "0x24867D4", Offset = "0x24867D4", VA = "0x7BBCC867D4")]
		private bool ResourceContains(ResourceID resourceID)
		{
			return default(bool);
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x00013128 File Offset: 0x00011328
		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0x2483658", Offset = "0x2483658", VA = "0x7BBCC83658")]
		private bool TryGetResourceConfigAB(ResourceID resourceID, out ResourceManager.ResourceConfigAB cfg)
		{
			return default(bool);
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x00013140 File Offset: 0x00011340
		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0x2483934", Offset = "0x2483934", VA = "0x7BBCC83934")]
		private bool TryGetResourceConfigABOrUrl(ResourceID resourceID, out ResourceManager.ResourceConfigAB cfg, out string url)
		{
			return default(bool);
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE3")]
		[Address(RVA = "0x2487744", Offset = "0x2487744", VA = "0x7BBCC87744")]
		private void ResetTicketGen()
		{
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06003CE4 RID: 15588 RVA: 0x00013158 File Offset: 0x00011358
		[Token(Token = "0x1700071A")]
		public static uint NewTicket
		{
			[Token(Token = "0x6003CE4")]
			[Address(RVA = "0x24877B0", Offset = "0x24877B0", VA = "0x7BBCC877B0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE5")]
		[Address(RVA = "0x2487820", Offset = "0x2487820", VA = "0x7BBCC87820")]
		private void RecycleRequest(ResourceManager.ResAsyncRequest request)
		{
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE6")]
		[Address(RVA = "0x2487930", Offset = "0x2487930", VA = "0x7BBCC87930")]
		private ResourceManager.ResAsyncRequest PoolGetRequest(string resPath, ResourceManager.ELoadAbOption abOpt, string abPath, Type type, bool noCache, bool noDestroy)
		{
			return null;
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x00013170 File Offset: 0x00011370
		[Token(Token = "0x6003CE7")]
		[Address(RVA = "0x2487C1C", Offset = "0x2487C1C", VA = "0x7BBCC87C1C")]
		public uint GetResource(uint ticket, ResourceID id, Action<uint, bool, UnityEngine.Object> callback, bool notUsingABForcefully = false, [Optional] Type type, bool noCache = false)
		{
			return 0U;
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00013188 File Offset: 0x00011388
		[Token(Token = "0x6003CE8")]
		[Address(RVA = "0x2488208", Offset = "0x2488208", VA = "0x7BBCC88208")]
		public uint GetResource(uint ticket, string resPath, Action<uint, bool, UnityEngine.Object> callback, bool notUsingABForcefully = false, bool noCache = false)
		{
			return 0U;
		}

		// Token: 0x06003CE9 RID: 15593 RVA: 0x000131A0 File Offset: 0x000113A0
		[Token(Token = "0x6003CE9")]
		[Address(RVA = "0x2488368", Offset = "0x2488368", VA = "0x7BBCC88368")]
		public uint GetResourceByNameAndAb(uint ticket, string resPath, string abPath, Action<uint, bool, UnityEngine.Object> callback, bool preload, bool noCache)
		{
			return 0U;
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEA")]
		[Address(RVA = "0x24884D4", Offset = "0x24884D4", VA = "0x7BBCC884D4")]
		public void CancelAsyncResLoad(uint ticket)
		{
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEB")]
		[Address(RVA = "0x2488688", Offset = "0x2488688", VA = "0x7BBCC88688")]
		public void UpdateAsyncLoadingRes()
		{
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEC")]
		[Address(RVA = "0x2482BA0", Offset = "0x2482BA0", VA = "0x7BBCC82BA0")]
		public void CleanUpAsyncLoadResRequests(bool cleanUpPool = false)
		{
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CED")]
		[Address(RVA = "0x2488D00", Offset = "0x2488D00", VA = "0x7BBCC88D00")]
		private void HandlePendingCleanUp()
		{
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEE")]
		[Address(RVA = "0x2488E3C", Offset = "0x2488E3C", VA = "0x7BBCC88E3C")]
		private void ClearListWithRecycle()
		{
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CEF")]
		[Address(RVA = "0x2488D1C", Offset = "0x2488D1C", VA = "0x7BBCC88D1C")]
		private void PumpAsyncResLoadRequestQueue()
		{
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF0")]
		[Address(RVA = "0x24892A0", Offset = "0x24892A0", VA = "0x7BBCC892A0")]
		public UnityEngine.Object FindLoadedResource(ResourceID resId)
		{
			return null;
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF1")]
		[Address(RVA = "0x24893B0", Offset = "0x24893B0", VA = "0x7BBCC893B0")]
		private UnityEngine.Object FindLoadedResource(string resPath)
		{
			return null;
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x000131B8 File Offset: 0x000113B8
		[Token(Token = "0x6003CF2")]
		[Address(RVA = "0x2487E1C", Offset = "0x2487E1C", VA = "0x7BBCC87E1C")]
		private uint EnqueueRequest(uint ticket, string resPath, Action<uint, bool, UnityEngine.Object> callback, ResourceManager.ELoadAbOption abOpt, string abPath = "", [Optional] Type type, bool noCache = false, bool dontDestroy = false)
		{
			return 0U;
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CF3")]
		[Address(RVA = "0x2488F30", Offset = "0x2488F30", VA = "0x7BBCC88F30")]
		private AsyncOperation GetResourceAsyncImpl(ResourceManager.ResAsyncRequest req)
		{
			return null;
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF4")]
		[Address(RVA = "0x24889D4", Offset = "0x24889D4", VA = "0x7BBCC889D4")]
		private void OnAsyncGetResCompleted(ResourceManager.ResAsyncRequest req)
		{
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x000131D0 File Offset: 0x000113D0
		[Token(Token = "0x6003CF5")]
		[Address(RVA = "0x2489890", Offset = "0x2489890", VA = "0x7BBCC89890")]
		public bool ParseResourceConf(Type ResID, Type EnumGame, Type EnumMode)
		{
			return default(bool);
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x000131E8 File Offset: 0x000113E8
		[Token(Token = "0x6003CF6")]
		[Address(RVA = "0x2489B34", Offset = "0x2489B34", VA = "0x7BBCC89B34")]
		private bool ParseResourceConfInternal(Type ResID, Type EnumGame, Type EnumMode, string jsonPath, bool overwrite = false)
		{
			return default(bool);
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF7")]
		[Address(RVA = "0x248AFE4", Offset = "0x248AFE4", VA = "0x7BBCC8AFE4")]
		private void parseResourceTag(List<string> abs, Type ResID, JsonData dataWithTag, out string url, out string ab, out string stream_ab, out ResourceManager.ELoadAbOption isAB, out string deps, out ResourceManager.EResourceConfigLevelSetting lowSetting, out ResourceManager.EResourceConfigLevelSetting highSetting, out MethodInfo modifier)
		{
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF8")]
		[Address(RVA = "0x248B8A4", Offset = "0x248B8A4", VA = "0x7BBCC8B8A4")]
		private void parseAndAddResourceMapping(Type ResID, string strName, string url, string ab, string stream_ab, ResourceManager.ELoadAbOption isAB, ResourceManager.EResourceConfigLevelSetting lowSetting, ResourceManager.EResourceConfigLevelSetting highSetting, MethodInfo modifier, bool needNameToResID, bool overwrite)
		{
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CF9")]
		[Address(RVA = "0x248AC58", Offset = "0x248AC58", VA = "0x7BBCC8AC58")]
		public void AddResourceMapping(string resPath, ResourceID resourceID)
		{
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFA")]
		[Address(RVA = "0x248C250", Offset = "0x248C250", VA = "0x7BBCC8C250")]
		public void AddResourceAnoymousMapping(string resName, bool anoymous, ResourceID resourceID)
		{
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFB")]
		[Address(RVA = "0x248BF60", Offset = "0x248BF60", VA = "0x7BBCC8BF60")]
		public void AddResconfDependenciesInNeed(string ab, string deps)
		{
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFC")]
		[Address(RVA = "0x2489AAC", Offset = "0x2489AAC", VA = "0x7BBCC89AAC")]
		private void InitPreloadDics()
		{
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFD")]
		[Address(RVA = "0x248A908", Offset = "0x248A908", VA = "0x7BBCC8A908")]
		private void ParsePreloadResIds(Type EnumGame, Type EnumMode)
		{
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFE")]
		[Address(RVA = "0x248C314", Offset = "0x248C314", VA = "0x7BBCC8C314")]
		private void AddPreloadList(Type EnumGame, Type EnumMode, List<KeyValuePair<string, List<string>>> enumToResNames, Dictionary<Enum, ResourceID[]> dst, bool forAudio = false)
		{
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CFF")]
		[Address(RVA = "0x248CA1C", Offset = "0x248CA1C", VA = "0x7BBCC8CA1C")]
		private void ParseResNames(List<string> resNames, List<ResourceID> resIDs, bool forAudio = false)
		{
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D00")]
		[Address(RVA = "0x2489968", Offset = "0x2489968", VA = "0x7BBCC89968")]
		private void InitResFieldsDict(Type ResID)
		{
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D01")]
		[Address(RVA = "0x248C1A0", Offset = "0x248C1A0", VA = "0x7BBCC8C1A0")]
		private FieldInfo GetResFieldInfoByName(string name)
		{
			return null;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D02")]
		[Address(RVA = "0x248CC78", Offset = "0x248CC78", VA = "0x7BBCC8CC78")]
		public static List<string> parseJsonStrList(JsonData JObjRoot, string name)
		{
			return null;
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D03")]
		[Address(RVA = "0x248AF74", Offset = "0x248AF74", VA = "0x7BBCC8AF74")]
		public static List<string> ParseResourceAbNames(JsonData JObjRoot)
		{
			return null;
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D04")]
		[Address(RVA = "0x248CDE4", Offset = "0x248CDE4", VA = "0x7BBCC8CDE4")]
		private static List<string> ParseStreamNameAbs(JsonData JObjRoot)
		{
			return null;
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D05")]
		[Address(RVA = "0x248CE54", Offset = "0x248CE54", VA = "0x7BBCC8CE54")]
		private static List<string> ParseStreamAbPathes(JsonData JObjRoot)
		{
			return null;
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D06")]
		[Address(RVA = "0x248AADC", Offset = "0x248AADC", VA = "0x7BBCC8AADC")]
		private static void ParseStreamAbs(JsonData JObjRoot, ref Dictionary<string, string> dst)
		{
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D07")]
		[Address(RVA = "0x248CEC4", Offset = "0x248CEC4", VA = "0x7BBCC8CEC4")]
		public ResourceManager()
		{
		}

		// Token: 0x04004DC3 RID: 19907
		[Token(Token = "0x4004DC3")]
		private const int CapacityResourcePaths = 16000;

		// Token: 0x04004DC4 RID: 19908
		[Token(Token = "0x4004DC4")]
		private const int CapacityResourceMappingAB = 4000;

		// Token: 0x04004DC5 RID: 19909
		[Token(Token = "0x4004DC5")]
		private const int CapacityResourceAnoymousMapping = 13500;

		// Token: 0x04004DC6 RID: 19910
		[Token(Token = "0x4004DC6")]
		private const int CapacityNameMapping = 9000;

		// Token: 0x04004DC7 RID: 19911
		[Token(Token = "0x4004DC7")]
		private const int CapacityLoadedResources = 500;

		// Token: 0x04004DC8 RID: 19912
		[Token(Token = "0x4004DC8")]
		private const int CapacityPreLoadedResources = 500;

		// Token: 0x04004DC9 RID: 19913
		[Token(Token = "0x4004DC9")]
		public const string StreamAbDirName = "streaming";

		// Token: 0x04004DCA RID: 19914
		[Token(Token = "0x4004DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string StreamAbDir;

		// Token: 0x04004DCB RID: 19915
		[Token(Token = "0x4004DCB")]
		public const string ResconfPath = "Config/Resconf";

		// Token: 0x04004DCC RID: 19916
		[Token(Token = "0x4004DCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ResourceID m_ResourcePathsStartID;

		// Token: 0x04004DCD RID: 19917
		[Token(Token = "0x4004DCD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private ResourceID m_ResourcePathsNextID;

		// Token: 0x04004DCE RID: 19918
		[Token(Token = "0x4004DCE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<string> m_ResourcePathsList;

		// Token: 0x04004DCF RID: 19919
		[Token(Token = "0x4004DCF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ResourceID m_ResourceMappingABStartID;

		// Token: 0x04004DD0 RID: 19920
		[Token(Token = "0x4004DD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private ResourceID m_ResourceMappingABNextID;

		// Token: 0x04004DD1 RID: 19921
		[Token(Token = "0x4004DD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ResourceManager.ResourceConfigAB> m_ResourceMappingABList;

		// Token: 0x04004DD2 RID: 19922
		[Token(Token = "0x4004DD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, ResourceID> m_ResourceAnoymousMapping;

		// Token: 0x04004DD3 RID: 19923
		[Token(Token = "0x4004DD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, ResourceID> m_ResourceAnoymousMappingTmp;

		// Token: 0x04004DD4 RID: 19924
		[Token(Token = "0x4004DD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<ResourceID, string> m_NameMapping;

		// Token: 0x04004DD5 RID: 19925
		[Token(Token = "0x4004DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<Enum, ResourceID[]> m_AudioPreloadResource;

		// Token: 0x04004DD6 RID: 19926
		[Token(Token = "0x4004DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<string, List<string>> m_ResconfDependencies;

		// Token: 0x04004DD7 RID: 19927
		[Token(Token = "0x4004DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Enum, ResourceID[]> m_PreloadResource;

		// Token: 0x04004DD8 RID: 19928
		[Token(Token = "0x4004DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<int, ResourceID[]> m_PreloadResource_PlayerAnimators;

		// Token: 0x04004DD9 RID: 19929
		[Token(Token = "0x4004DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_HasInited;

		// Token: 0x04004DDA RID: 19930
		[Token(Token = "0x4004DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool m_HasParsed;

		// Token: 0x04004DDB RID: 19931
		[Token(Token = "0x4004DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private AssetBundleManifest m_ABManifest;

		// Token: 0x04004DDC RID: 19932
		[Token(Token = "0x4004DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool m_UseAssetBundle;

		// Token: 0x04004DDD RID: 19933
		[Token(Token = "0x4004DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Dictionary<string, UnityEngine.Object> m_LoadedResources;

		// Token: 0x04004DDE RID: 19934
		[Token(Token = "0x4004DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<string, AssetBundle> m_ResourceBundle;

		// Token: 0x04004DDF RID: 19935
		[Token(Token = "0x4004DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Dictionary<string, UnityEngine.Object> m_DontDestroyLoadedResources;

		// Token: 0x04004DE0 RID: 19936
		[Token(Token = "0x4004DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<string, AssetBundle> m_DontDestroyResourceBundle;

		// Token: 0x04004DE1 RID: 19937
		[Token(Token = "0x4004DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<string, UnityEngine.Object> m_PreLoadedResources;

		// Token: 0x04004DE2 RID: 19938
		[Token(Token = "0x4004DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Dictionary<string, AssetBundle> m_PreLoadedResourceBundles;

		// Token: 0x04004DE3 RID: 19939
		[Token(Token = "0x4004DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<string, string> m_StreamAbs;

		// Token: 0x04004DE4 RID: 19940
		[Token(Token = "0x4004DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private string[] mPersisitResources;

		// Token: 0x04004DE5 RID: 19941
		[Token(Token = "0x4004DE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private GGfm}Dt ResQualityLevel;

		// Token: 0x04004DE6 RID: 19942
		[Token(Token = "0x4004DE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool UseSceneFolderAB;

		// Token: 0x04004DE7 RID: 19943
		[Token(Token = "0x4004DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Type mResIDType;

		// Token: 0x04004DE8 RID: 19944
		[Token(Token = "0x4004DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Dictionary<string, FieldInfo> mResIDFieldInfos;

		// Token: 0x04004DE9 RID: 19945
		[Token(Token = "0x4004DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<ResourceRefCache> m_RefCaches;

		// Token: 0x04004DEA RID: 19946
		[Token(Token = "0x4004DEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly LinkedList<ResourceManager.ResAsyncRequest> mResAsyncRequestList;

		// Token: 0x04004DEB RID: 19947
		[Token(Token = "0x4004DEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool mPendingCleanUp;

		// Token: 0x04004DEC RID: 19948
		[Token(Token = "0x4004DEC")]
		public const uint InvalidTicket = 0U;

		// Token: 0x04004DED RID: 19949
		[Token(Token = "0x4004DED")]
		public const uint InstantCallTicket = 1U;

		// Token: 0x04004DEE RID: 19950
		[Token(Token = "0x4004DEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static uint ticketGen;

		// Token: 0x04004DEF RID: 19951
		[Token(Token = "0x4004DEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly List<ResourceManager.ResAsyncRequest> mResAsyncRequestPool;

		// Token: 0x04004DF0 RID: 19952
		[Token(Token = "0x4004DF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool mTempDisablePooling;

		// Token: 0x04004DF1 RID: 19953
		[Token(Token = "0x4004DF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private List<ResourceManager.ResAsyncRequest> requestsToRemove;

		// Token: 0x04004DF2 RID: 19954
		[Token(Token = "0x4004DF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<KeyValuePair<string, List<string>>> m_PreloadAssets;

		// Token: 0x04004DF3 RID: 19955
		[Token(Token = "0x4004DF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<KeyValuePair<string, List<string>>> m_PreloadAssetsAudio;

		// Token: 0x04004DF4 RID: 19956
		[Token(Token = "0x4004DF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<string> m_PreloadAnimatorsNormal;

		// Token: 0x04004DF5 RID: 19957
		[Token(Token = "0x4004DF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private List<string> m_PreloadAnimatorsHd;

		// Token: 0x02000FF6 RID: 4086
		[Token(Token = "0x2000FF6")]
		public enum EResourceConfigLevelSetting : byte
		{
			// Token: 0x04004DF7 RID: 19959
			[Token(Token = "0x4004DF7")]
			None,
			// Token: 0x04004DF8 RID: 19960
			[Token(Token = "0x4004DF8")]
			Replace,
			// Token: 0x04004DF9 RID: 19961
			[Token(Token = "0x4004DF9")]
			Hide
		}

		// Token: 0x02000FF7 RID: 4087
		[Token(Token = "0x2000FF7")]
		public enum ELoadAbOption : byte
		{
			// Token: 0x04004DFB RID: 19963
			[Token(Token = "0x4004DFB")]
			NotAb,
			// Token: 0x04004DFC RID: 19964
			[Token(Token = "0x4004DFC")]
			AbWithName,
			// Token: 0x04004DFD RID: 19965
			[Token(Token = "0x4004DFD")]
			AbWithPath,
			// Token: 0x04004DFE RID: 19966
			[Token(Token = "0x4004DFE")]
			AbWithNameOrPath,
			// Token: 0x04004DFF RID: 19967
			[Token(Token = "0x4004DFF")]
			StreamAb
		}

		// Token: 0x02000FF8 RID: 4088
		[Token(Token = "0x2000FF8")]
		public class ResourceConfigAB
		{
			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x06003D09 RID: 15625 RVA: 0x00013200 File Offset: 0x00011400
			[Token(Token = "0x1700071B")]
			public bool IsAb
			{
				[Token(Token = "0x6003D09")]
				[Address(RVA = "0x2483758", Offset = "0x2483758", VA = "0x7BBCC83758")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003D0A RID: 15626 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D0A")]
			[Address(RVA = "0x2483C64", Offset = "0x2483C64", VA = "0x7BBCC83C64")]
			public string GetPath(GGfm}Dt s)
			{
				return null;
			}

			// Token: 0x06003D0B RID: 15627 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003D0B")]
			[Address(RVA = "0x248D2D4", Offset = "0x248D2D4", VA = "0x7BBCC8D2D4")]
			private static string AppendSuffix(ResourceManager.ELoadAbOption abOpt, string path, string suffix)
			{
				return null;
			}

			// Token: 0x06003D0C RID: 15628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D0C")]
			[Address(RVA = "0x2486C00", Offset = "0x2486C00", VA = "0x7BBCC86C00")]
			public ResourceConfigAB()
			{
			}

			// Token: 0x04004E00 RID: 19968
			[Token(Token = "0x4004E00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string m_path;

			// Token: 0x04004E01 RID: 19969
			[Token(Token = "0x4004E01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string m_abPath;

			// Token: 0x04004E02 RID: 19970
			[Token(Token = "0x4004E02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MethodInfo m_Modifier;

			// Token: 0x04004E03 RID: 19971
			[Token(Token = "0x4004E03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResourceManager.EResourceConfigLevelSetting m_LevelLow;

			// Token: 0x04004E04 RID: 19972
			[Token(Token = "0x4004E04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public ResourceManager.EResourceConfigLevelSetting m_LevelHigh;

			// Token: 0x04004E05 RID: 19973
			[Token(Token = "0x4004E05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
			public ResourceManager.ELoadAbOption m_AbOption;
		}

		// Token: 0x02000FF9 RID: 4089
		[Token(Token = "0x2000FF9")]
		public class ResourceConfigStreamAB : ResourceManager.ResourceConfigAB
		{
			// Token: 0x06003D0D RID: 15629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D0D")]
			[Address(RVA = "0x248C248", Offset = "0x248C248", VA = "0x7BBCC8C248")]
			public ResourceConfigStreamAB()
			{
			}

			// Token: 0x04004E06 RID: 19974
			[Token(Token = "0x4004E06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string m_streamABPath;
		}

		// Token: 0x02000FFA RID: 4090
		[Token(Token = "0x2000FFA")]
		private class ResAsyncRequest
		{
			// Token: 0x06003D0E RID: 15630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D0E")]
			[Address(RVA = "0x2487B44", Offset = "0x2487B44", VA = "0x7BBCC87B44")]
			public ResAsyncRequest(string resPath, ResourceManager.ELoadAbOption abOpt, string abPath, Type type, bool noCache, bool noDestroy)
			{
			}

			// Token: 0x06003D0F RID: 15631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D0F")]
			[Address(RVA = "0x2487A8C", Offset = "0x2487A8C", VA = "0x7BBCC87A8C")]
			public void Init(string resPath, ResourceManager.ELoadAbOption abOpt, string abPath, Type type, bool noCache, bool noDestroy)
			{
			}

			// Token: 0x06003D10 RID: 15632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D10")]
			[Address(RVA = "0x2489484", Offset = "0x2489484", VA = "0x7BBCC89484")]
			public void RegisterAction(uint ticket, Action<uint, bool, UnityEngine.Object> callback)
			{
			}

			// Token: 0x06003D11 RID: 15633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D11")]
			[Address(RVA = "0x248D228", Offset = "0x248D228", VA = "0x7BBCC8D228")]
			public void UnregisterAction(uint ticket)
			{
			}

			// Token: 0x06003D12 RID: 15634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003D12")]
			[Address(RVA = "0x24896E8", Offset = "0x24896E8", VA = "0x7BBCC896E8")]
			public void InvokeActions(bool succeeded, UnityEngine.Object obj)
			{
			}

			// Token: 0x04004E07 RID: 19975
			[Token(Token = "0x4004E07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string ResPath;

			// Token: 0x04004E08 RID: 19976
			[Token(Token = "0x4004E08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type Type;

			// Token: 0x04004E09 RID: 19977
			[Token(Token = "0x4004E09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ResourceManager.ELoadAbOption ABOption;

			// Token: 0x04004E0A RID: 19978
			[Token(Token = "0x4004E0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string ABPath;

			// Token: 0x04004E0B RID: 19979
			[Token(Token = "0x4004E0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool NoCache;

			// Token: 0x04004E0C RID: 19980
			[Token(Token = "0x4004E0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool NoDestroy;

			// Token: 0x04004E0D RID: 19981
			[Token(Token = "0x4004E0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Dictionary<uint, Action<uint, bool, UnityEngine.Object>> Callbacks;

			// Token: 0x04004E0E RID: 19982
			[Token(Token = "0x4004E0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public AsyncOperation AsyncOp;

			// Token: 0x04004E0F RID: 19983
			[Token(Token = "0x4004E0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public ResourceManager.ResAsyncRequest.ReqState State;

			// Token: 0x02000FFB RID: 4091
			[Token(Token = "0x2000FFB")]
			public enum ReqState : byte
			{
				// Token: 0x04004E11 RID: 19985
				[Token(Token = "0x4004E11")]
				Waiting,
				// Token: 0x04004E12 RID: 19986
				[Token(Token = "0x4004E12")]
				InProgress,
				// Token: 0x04004E13 RID: 19987
				[Token(Token = "0x4004E13")]
				Completed,
				// Token: 0x04004E14 RID: 19988
				[Token(Token = "0x4004E14")]
				Cancelled,
				// Token: 0x04004E15 RID: 19989
				[Token(Token = "0x4004E15")]
				Recycled
			}
		}
	}
}
