(clojure.core/refer-clojure)

(def not-lean-vars #{})

(binding [*lean-compile* true
          *compile-path* "./target"
          *compiler-options* {:elide-meta [:doc :file :line :added :arglists
                                           :column :static :dynamic
                                           :author :added :declared :private]
                              :neko.init/release-build true}
          *lean-var?* (fn [^clojure.lang.Var v]
                        (when-not (not-lean-vars (str v))
                          v))]
  (compile 'skummet-check.one)
  (compile 'skummet-check.hello))
